using System.Collections.Generic;
using Crescive.CreatorMode;
using Crescive.Levels;
using UnityEngine;

namespace Game.Systems.StageLevels.Data
{
	[CreateAssetMenu(fileName = "Stage_Levels_Funnel", menuName = "Level Creator/Stage Levels Funnel")]
	public class StageLevelsFunnelData : ScriptableObject
	{
		[SerializeField]
		private List<LevelFunnelData> stages;

		public LevelCreatorData? GetStageData(int levelIndexInStageLevels, int stageIndex)
		{
			return null;
		}

		public int GetStageCount()
		{
			return 0;
		}

		public bool HasStageData(int levelIndexInStageLevels)
		{
			return false;
		}
	}
}
