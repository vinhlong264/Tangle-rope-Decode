const state={levels:[],active:null,viewMode:'2d'};
const colors=['#e84c7d','#287ed8','#39aa60','#ef9a28','#9c55d3','#e24a42','#1aa7a1','#cfb122','#6d7e91','#f072c3'];
const el=id=>document.getElementById(id);
const escapeHtml=value=>String(value).replace(/[&<>"']/g,c=>({'&':'&amp;','<':'&lt;','>':'&gt;','"':'&quot;',"'":'&#39;'}[c]));
function parseVec(text){const m=text.match(/x:\s*([-+.\deE]+),\s*y:\s*([-+.\deE]+),\s*z:\s*([-+.\deE]+)/);return m?{x:+m[1],y:+m[2],z:+m[3]}:null}
function section(text,name){const re=new RegExp('^ {6}'+name+':([\\s\\S]*?)(?=^ {6}[A-Za-z][A-Za-z0-9_]*:|^ {4}[A-Za-z][A-Za-z0-9_]*:|(?![\\s\\S]))','m');return (text.match(re)||['',''])[1]}
function topSection(text,name){const re=new RegExp('^ {4}'+name+':([\\s\\S]*?)(?=^ {4}[A-Za-z][A-Za-z0-9_]*:|(?![\\s\\S]))','m');return (text.match(re)||['',''])[1]}
function vecs(block,pattern){return (block.match(pattern)||[]).map(parseVec).filter(Boolean)}
function ints(block,field){return [...block.matchAll(new RegExp(field+':\\s*(\\d+)','g'))].map(m=>+m[1])}
function parseObstacles(block){return [...block.matchAll(/^ {6}- ObstacleType:\s*(\S+)([\s\S]*?)(?=^ {6}- ObstacleType:|(?![\s\S]))/gm)].map(m=>{const color=(m[2].match(/ObstacleColor:\s*\{r:\s*([-+.\deE]+),\s*g:\s*([-+.\deE]+),\s*b:\s*([-+.\deE]+)/)||[]);const rgb=color.length?`rgb(${Math.round(+color[1]*255)} ${Math.round(+color[2]*255)} ${Math.round(+color[3]*255)})`:'#7a8ca2';return {type:m[1],hp:+((m[2].match(/Hp:\s*(\d+)/)||[,1])[1]),color:rgb,positions:vecs(m[2],/- \{x:\s*[^}]+\}/g)}})}
function parseAsset(text,fileName){const levelId=(text.match(/^  levelId:\s*(\d+)/m)||[,fileName.match(/\d+/)?.[0]||'?'])[1];const stageText=topSection(text,'stagesData');const stages=[];const chunks=stageText.split(/^    - pinsData:/m).slice(1);for(const chunk of chunks){const pins=vecs(section('      pinsData:'+chunk,'pinsData'),/Position:\s*\{[^}]+\}/g);const ropes=[];const ropeBlock=section(chunk,'ropesData');for(const ropeChunk of ropeBlock.split(/^      - Position:/m).slice(1)){const particles=vecs(ropeChunk,/position:\s*\{[^}]+\}/g).filter(p=>!(p.x===-1&&p.y===0&&p.z===-4));if(particles.length>1)ropes.push(particles)}const columns=vecs(section(chunk,'columnsData'),/Position:\s*\{[^}]+\}/g);const clamps=vecs(section(chunk,'clampsData'),/Position:\s*\{[^}]+\}/g);const obstacles=parseObstacles(section(chunk,'liveObstaclesData'));stages.push({pins,ropes,columns,clamps,obstacles,keys:ints(section(chunk,'keysData'),'RopeIndex'),locks:ints(section(chunk,'lockSlotsData'),'Index'),goldenRopes:ints(section(chunk,'goldenRopesData'),'RopeIndex'),ropeWidths:ints(section(chunk,'ropeWidthsData'),'RopeIndex')})}const time=(text.match(/^ {6}timeLimit:\s*(\d+)/m)||[,0])[1];const moves=(text.match(/^ {6}moveCount:\s*(\d+)/m)||[,0])[1];const difficulty=(text.match(/^ {6}difficulty:\s*(.+)$/m)||[,'—'])[1].trim();return {id:+levelId||levelId,name:fileName.replace(/\.asset$/i,''),stages,time:+time,moves:+moves,difficulty};}
function formatTime(seconds){return seconds?`${String(Math.floor(seconds/60)).padStart(2,'0')}:${String(seconds%60).padStart(2,'0')}`:'--:--'}
function renderList(){const q=el('search').value.toLowerCase();const items=state.levels.filter(x=>x.name.toLowerCase().includes(q)).sort((a,b)=>Number(a.id)-Number(b.id));el('levelList').innerHTML=items.length?items.map(x=>`<button class="level-item ${state.active===x?'active':''}" data-name="${escapeHtml(x.name)}"><span>${escapeHtml(x.name)}</span><small>${x.stages.length} stage</small></button>`).join(''):'<p class="empty">Không tìm thấy level.</p>';el('levelList').querySelectorAll('button').forEach(b=>b.onclick=()=>selectLevel(state.levels.find(x=>x.name===b.dataset.name)))}
function selectLevel(level){state.active=level;el('levelName').textContent=level.name;el('levelMeta').textContent=`ID ${level.id} · ${level.stages.length} stage · ${level.difficulty}`;el('gameLevel').textContent=level.id;el('gameTimer').textContent=formatTime(level.time);el('timerTitle').textContent=level.moves?'MOVES':'TIME';if(level.moves)el('gameTimer').textContent=level.moves;el('stageSelect').disabled=false;el('stageSelect').innerHTML=level.stages.map((_,i)=>`<option value="${i}">Stage ${i+1}</option>`).join('');el('stageSelect').onchange=()=>renderStage(+el('stageSelect').value);renderList();renderStage(0)}
function renderStage(index){const s=state.active.stages[index]||{pins:[],ropes:[],columns:[],clamps:[],obstacles:[]};const points=[...s.pins,...s.ropes.flat(),...s.columns,...s.clamps,...s.obstacles.flatMap(o=>o.positions)];let xs=points.map(p=>p.x),zs=points.map(p=>p.z);let minX=Math.min(...xs,-2),maxX=Math.max(...xs,2),minZ=Math.min(...zs,-2),maxZ=Math.max(...zs,2);const pad=Math.max(maxX-minX,maxZ-minZ)*.16+.4;minX-=pad;maxX+=pad;minZ-=pad;maxZ+=pad;const map=p=>({x:80+(p.x-minX)/(maxX-minX)*840,y:920-(p.z-minZ)/(maxZ-minZ)*840});const ropeSvg=s.ropes.map((rope,i)=>{const d=rope.map((p,j)=>`${j?'L':'M'} ${map(p).x.toFixed(1)} ${map(p).y.toFixed(1)}`).join(' ');const golden=s.goldenRopes.includes(i);const c=golden?'#f4c431':colors[i%colors.length];return `<path d="${d}" fill="none" stroke="#273747" stroke-width="27" stroke-linecap="round" stroke-linejoin="round" opacity=".8"/><path d="${d}" fill="none" stroke="${c}" stroke-width="17" stroke-linecap="round" stroke-linejoin="round"/>`}).join('');const obstacleSvg=s.obstacles.flatMap(o=>o.positions.map(p=>{const q=map(p);return `<g transform="translate(${q.x} ${q.y})"><rect x="-36" y="-36" width="72" height="72" rx="12" fill="#263746"/><rect x="-29" y="-29" width="58" height="58" rx="9" fill="${o.color}"/><path d="M-18 -8h36M-18 8h36" stroke="#fff" stroke-width="6" opacity=".72"/><text y="7" text-anchor="middle" fill="#253647" font-size="20" font-weight="900">${o.hp}</text></g>`})).join('');const columnSvg=s.columns.map(p=>{const q=map(p);return `<g transform="translate(${q.x} ${q.y})"><ellipse cy="22" rx="37" ry="15" fill="#263746"/><rect x="-25" y="-46" width="50" height="67" rx="13" fill="#8998a8"/><ellipse cy="-45" rx="25" ry="12" fill="#d4dde5"/><path d="M-16 -33h32" stroke="#5e7182" stroke-width="7"/></g>`}).join('');const clampSvg=s.clamps.map(p=>{const q=map(p);return `<g transform="translate(${q.x} ${q.y})"><circle r="35" fill="#293947"/><path d="M-24 18V-8a24 24 0 0 1 48 0v26H10V-8a10 10 0 0 0-20 0v26z" fill="#efb52e" stroke="#ffe48d" stroke-width="5"/><rect x="-29" y="16" width="58" height="28" rx="8" fill="#e0573f"/></g>`}).join('');const pinSvg=s.pins.map(p=>{const q=map(p);return `<g transform="translate(${q.x} ${q.y})"><circle r="30" fill="#263846"/><circle r="23" fill="#d9e0e4"/><circle r="10" fill="#667c89"/><path d="M-20 23h40l-8 18h-24z" fill="#2a3c49"/></g>`}).join('');el('boardSvg').innerHTML=`<defs><filter id="shadow"><feDropShadow dx="1" dy="4" stdDeviation="3" flood-opacity=".32"/></filter></defs><g filter="url(#shadow)">${ropeSvg}${obstacleSvg}${columnSvg}${clampSvg}${pinSvg}</g>`;const obstacleCount=s.columns.length+s.clamps.length+s.obstacles.reduce((total,o)=>total+o.positions.length,0);el('stats').innerHTML=`<div><dt>Dây</dt><dd>${s.ropes.length}</dd></div><div><dt>Chốt</dt><dd>${s.pins.length}</dd></div><div><dt>Vật cản</dt><dd>${obstacleCount}</dd></div><div><dt>Độ khó</dt><dd>${escapeHtml(state.active.difficulty)}</dd></div>`}
async function loadFiles(files){const candidates=files.filter(file=>/\.asset$/i.test(file.name));const assets=[];for(let index=0;index<candidates.length;index+=1){if(index%25===0){el('loadHint').textContent=`Đang đọc level ${index+1}/${candidates.length}…`;await new Promise(resolve=>setTimeout(resolve,0))}const file=candidates[index];assets.push(parseAsset(await file.text(),file.name))}state.levels=assets.filter(x=>x.stages.length).sort((a,b)=>Number(a.id)-Number(b.id));el('search').disabled=!state.levels.length;el('loadHint').textContent=state.levels.length?`Đã nạp ${state.levels.length} level. Chọn một level để xem.`:'Không nhận diện được stage nào. Hãy chọn đúng thư mục chứa các file Level .asset.';renderList();if(state.levels.length)selectLevel(state.levels[0])}
if(typeof document!=='undefined'){el('pickFiles').onchange=e=>loadFiles([...e.target.files]);el('search').oninput=renderList;el('fitBoard').onclick=()=>state.active&&renderStage(+el('stageSelect').value||0);
el('pickFolder').onclick=async()=>{if(!window.showDirectoryPicker){el('loadHint').textContent='Trình duyệt này không hỗ trợ chọn thư mục. Hãy dùng nút chọn nhiều file.';return}try{const h=await window.showDirectoryPicker();const files=[];for await(const entry of h.values())if(entry.kind==='file'&&entry.name.endsWith('.asset'))files.push(await entry.getFile());await loadFiles(files)}catch(e){if(e.name!=='AbortError')el('loadHint').textContent='Không thể đọc thư mục đã chọn.'}}}
if(typeof document!=='undefined'){el('viewToggle').onclick=()=>{state.viewMode=state.viewMode==='2d'?'3d':'2d';const is3d=state.viewMode==='3d';el('viewToggle').textContent=is3d?'◇ View 2D':'◇ View 3D';el('viewToggle').classList.toggle('active',is3d);el('boardSvg').style.transform=is3d?'perspective(700px) rotateX(43deg) rotateZ(-8deg) scale(.86)':'none';el('boardSvg').style.transformOrigin='50% 55%';el('boardSvg').style.transition='transform .35s ease';el('gameBoard').classList.toggle('is-3d',is3d)}}
function runtimePosition(p){return {x:+(-p.x*1.7).toFixed(2),y:+(p.y||0).toFixed(2),z:+(-p.z*1.7).toFixed(2)}}
function runtimeRopePosition(p){return {x:+(p.x*1.7).toFixed(2),y:+(p.y||0).toFixed(2),z:+(p.z*1.7).toFixed(2)}}
function toLevelProperties(level){const s=level.stages[0]||{pins:[],ropes:[],columns:[],clamps:[],obstacles:[],keys:[],locks:[]};const basis=[...s.pins,...s.columns];const maxX=Math.max(...basis.map(p=>Math.abs(p.x)),1.5),maxZ=Math.max(...basis.map(p=>Math.abs(p.z)),2.5);const row=Math.max(6,Math.ceil(maxZ*2+1-.001)),column=Math.max(4,Math.ceil(maxX*2+1-.001));const coordinate=p=>({row:Math.round(p.z+(row-1)*.5),column:column-1-Math.round(p.x+(column-1)*.5)});const rot=p=>({...runtimePosition(p),rotX:0,rotY:0,rotZ:0,rotW:1});const ropes=(s.ropes||[]).map((rope,id)=>({isRescueRope:false,id,color:id%8,pos:rope.map(runtimeRopePosition),neos:[{isStatic:false,rescueType:0,objectPos:{...runtimeRopePosition(rope[0]),rotX:0,rotY:0,rotZ:0,rotW:1}},{isStatic:false,rescueType:0,objectPos:{...runtimeRopePosition(rope[rope.length-1]),rotX:0,rotY:0,rotZ:0,rotW:1}}]}));const obstacleColor=o=>{const m=String(o.color||'').match(/(\d+)/g)||[122,140,162];return {r:+m[0]/255,g:+m[1]/255,b:+m[2]/255,a:1}};const liveObstaclesData=(s.obstacles||[]).map(o=>({ObstacleType:+o.type||0,Positions:o.positions.map(runtimeRopePosition),Rotation:{x:0,y:0,z:0},obstacleSubType:0,Hp:o.hp,ObstacleColor:obstacleColor(o)}));const result={level:level.id,row,column,time:level.time||300,ropeDatas:ropes,staticNodeDatas:(s.columns||[]).map(coordinate),adsNodes:null,blockNodes:(s.locks||[]).map(i=>({row:Math.floor(i/column),column:column-1-(i%column)})),liveObstaclesData:liveObstaclesData.length?liveObstaclesData:null,useNearColors:false,customeNearColors:null};for(let i=0;i<Math.min(2,(s.clamps||[]).length);i+=1){const suffix=i?'2':'';result[`lockPos${suffix}`]=rot(s.clamps[i]);const ropeId=s.keys?.[i];if(Number.isInteger(ropeId)&&ropes[ropeId]){const path=s.ropes[ropeId];result[`keyData${suffix}`]={ropeId,keyPos:rot(path[Math.floor(path.length/2)])}}}return result}

function refreshExportGroups() {
  const groupsCount = Math.ceil(state.levels.length / 50);
  let options = `<option value="all">Tất cả nhóm (Xuất hết)</option>`;
  
  for (let i = 0; i < groupsCount; i++) {
    const start = i * 50 + 1;
    const end = (i + 1) * 50;
    options += `<option value="${i}">Level${start}-${end}</option>`;
  }

  el('exportGroup').innerHTML = options;
  el('exportGroup').disabled = !state.levels.length;
  el('exportGroupButton').disabled = !state.levels.length;
}

function saveJsonFile(data, fileName) {
  const blob = new Blob([JSON.stringify(data, null, 2)], { type: 'application/json' });
  const url = URL.createObjectURL(blob);
  const link = document.createElement('a');
  link.href = url;
  link.download = fileName;
  link.click();
  setTimeout(() => URL.revokeObjectURL(url), 100);
}

async function downloadExportGroup() {
  const selectedValue = el('exportGroup').value;
  
  if (selectedValue === 'all') {
    const groupsCount = Math.ceil(state.levels.length / 50);
    for (let i = 0; i < groupsCount; i++) {
      const start = i * 50 + 1;
      const end = (i + 1) * 50;
      const groupLevels = state.levels.slice(i * 50, (i + 1) * 50).map(toLevelProperties);
      
      if (groupLevels.length > 0) {
        saveJsonFile(groupLevels, `Level${start}-${end}.json`);
        await new Promise(resolve => setTimeout(resolve, 200));
      }
    }
  } else {
    const group = +selectedValue;
    const start = group * 50 + 1;
    const end = (group + 1) * 50;
    const levels = state.levels.slice(group * 50, (group + 1) * 50).map(toLevelProperties);
    
    saveJsonFile(levels, `Level${start}-${end}.json`);
  }
}

if(typeof document!=='undefined'){const originalLoadFiles=loadFiles;loadFiles=async files=>{await originalLoadFiles(files);refreshExportGroups()};el('exportGroupButton').onclick=downloadExportGroup}