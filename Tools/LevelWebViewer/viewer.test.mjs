import assert from 'node:assert/strict';
import { readFile } from 'node:fs/promises';
import { fileURLToPath } from 'node:url';
import vm from 'node:vm';

const assetPath = fileURLToPath(new URL('../../Assets/Resources/levels/so/Level 1.asset', import.meta.url));
const asset = await readFile(assetPath, 'utf8');
const viewerPath = fileURLToPath(new URL('./viewer.js', import.meta.url));
const viewerSource = await readFile(viewerPath, 'utf8');
const context = {};
vm.runInNewContext(viewerSource, context);
const level = context.parseAsset(asset, 'Level 1.asset');

assert.equal(level.id, 1);
assert.equal(level.stages.length, 1);
assert.equal(level.stages[0].pins.length, 4);
assert.equal(level.stages[0].ropes.length, 2);
assert.equal(level.time, 300);
console.log('Level 1 parsed:', level.stages[0].pins.length, 'pins,', level.stages[0].ropes.length, 'ropes');

const obstaclePath = fileURLToPath(new URL('../../Assets/Resources/levels/so/Level 1151.asset', import.meta.url));
const obstacleAsset = await readFile(obstaclePath, 'utf8');
const obstacleLevel = context.parseAsset(obstacleAsset, 'Level 1151.asset');
assert.equal(obstacleLevel.stages[0].obstacles.length, 1);
assert.equal(obstacleLevel.stages[0].obstacles[0].positions.length, 9);
assert.equal(obstacleLevel.stages[0].obstacles[0].hp, 3);
console.log('Level 1151 parsed:', obstacleLevel.stages[0].obstacles[0].positions.length, 'obstacle tiles');
