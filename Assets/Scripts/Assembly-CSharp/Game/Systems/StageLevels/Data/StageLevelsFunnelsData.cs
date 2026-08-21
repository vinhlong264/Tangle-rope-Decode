using System.Collections.Generic;
using UnityEngine;

namespace Game.Systems.StageLevels.Data
{
	[CreateAssetMenu(fileName = "Stage_Levels_Funnels", menuName = "Level Creator/Stage Levels Funnels")]
	public class StageLevelsFunnelsData : ScriptableObject
	{
		[SerializeField]
		private List<StageLevelsFunnelData> stageLevelsFunnels;

		public StageLevelsFunnelData? GetFunnel(int funnelIndex)
		{
			return null;
		}
	}
}
