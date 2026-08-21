using System.Collections.Generic;
using Crescive.AutoLayout;
using Crescive.CreatorMode;
using Crescive.Draggables;
using Crescive.Levels;
using Crescive.TwistedTangle.Channel;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class LevelSaver : BaseLevelSaver<LevelCreatorData, LevelCreatorSaveData>
	{
		[SerializeField]
		private LoadedLevelDataChannel loadedLevelDataChannel;

		[SerializeField]
		private PinsChannel pinsChannel;

		[SerializeField]
		private PinSlotsChannel pinSlotsChannel;

		[SerializeField]
		private RopesChannel ropesChannel;

		[SerializeField]
		private DraggablesChannel columnsChannel;

		[SerializeField]
		private ClampsChannel clampsChannel;

		[SerializeField]
		private KeysChannel keysChannel;

		[SerializeField]
		private TransformAutoGridLayoutChannel gridLayoutChannel;

		[SerializeField]
		private BoolVariable useNearColors;

		[SerializeField]
		private BoolVariable useCustomNearColors;

		[SerializeField]
		private ColorValueList customNearColors;

		[SerializeField]
		private IntVariable moveCount;

		[SerializeField]
		private BoolVariable hasMoveCount;

		[SerializeField]
		private BoolVariable hasTimeLimit;

		[SerializeField]
		private IntVariable timeLimit;

		[SerializeField]
		private MapProfileData mapProfileData;

		[SerializeField]
		private StringVariable difficultyDetailed;

		[SerializeField]
		private IntReference currentStageIndex;

		public LevelCreatorSaveData.StateData GetCurrentState()
		{
			return null;
		}

		private List<PinData> GetPinsSaveData()
		{
			return null;
		}

		private List<RopeData> GetRopesSaveData()
		{
			return null;
		}

		private List<ColumnData> GetColumnsSaveData()
		{
			return null;
		}

		private List<ClampData> GetClampsSaveData()
		{
			return null;
		}

		private List<LiveObstacleData> GetLiveObstaclesSaveData()
		{
			return null;
		}

		private List<KeyData> GetKeysSaveData()
		{
			return null;
		}

		private List<LockSlotData> GetLockSlotsSaveData()
		{
			return null;
		}

		private List<GoldenRopeData> GetGoldenRopesSaveData()
		{
			return null;
		}

		private List<RopeWidthData> GetRopeWidthsSaveData()
		{
			return null;
		}

		private void UpdateCurrentStageData(LevelCreatorSaveData.StageData stageData)
		{
		}

		public override LevelCreatorSaveData GetLevelSaveData()
		{
			return null;
		}
	}
}
