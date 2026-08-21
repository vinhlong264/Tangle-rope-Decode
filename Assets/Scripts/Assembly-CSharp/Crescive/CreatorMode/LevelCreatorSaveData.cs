using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Crescive.CreatorMode
{
	[Serializable]
	public class LevelCreatorSaveData : BaseCreatorSaveData
	{
		[Serializable]
		public class LevelData : ICloneable
		{
			public bool hasMoveCount;

			public int moveCount;

			public bool hasTimeLimit;

			public int timeLimit;

			public string difficulty;

			public int version;

			public object Clone()
			{
				return null;
			}
		}

		[Serializable]
		public class ColorTargetData
		{
			public int ColorIndex;

			public int TargetCount;
		}

		[Serializable]
		public class StateData
		{
			public List<PinData> pinsData;

			public List<RopeData> ropesData;
		}

		[Serializable]
		public class StageData : ICloneable
		{
			public List<PinData> pinsData;

			public List<RopeData> ropesData;

			public List<ColumnData> columnsData;

			public List<ClampData> clampsData;

			public List<KeyData> keysData;

			public List<LockSlotData> lockSlotsData;

			public List<GoldenRopeData> goldenRopesData;

			public List<RopeWidthData> ropeWidthsData;

			public List<LiveObstacleData> liveObstaclesData;

			public List<int> Colors;

			public List<ColorTargetData> Targets;

			public bool useNearColors;

			public bool useCustomNearColors;

			public List<Color> customNearColors;

			public int mapId;

			public object Clone()
			{
				return null;
			}
		}

		public List<StageData> stagesData;

		public LevelData levelData;

		[FormerlySerializedAs("pinsData")]
		[HideInInspector]
		[Obsolete]
		public List<PinData> pinsData_;

		[FormerlySerializedAs("ropesData")]
		[Obsolete]
		[HideInInspector]
		public List<RopeData> ropesData_;

		[FormerlySerializedAs("columnsData")]
		[HideInInspector]
		[Obsolete]
		public List<ColumnData> columnsData_;

		[Obsolete]
		[FormerlySerializedAs("clampsData")]
		[HideInInspector]
		public List<ClampData> clampsData_;

		[FormerlySerializedAs("keysData")]
		[HideInInspector]
		[Obsolete]
		public List<KeyData> keysData_;

		[FormerlySerializedAs("lockSlotsData")]
		[HideInInspector]
		[Obsolete]
		public List<LockSlotData> lockSlotsData_;

		[FormerlySerializedAs("goldenRopesData")]
		[HideInInspector]
		[Obsolete]
		public List<GoldenRopeData> goldenRopesData_;

		[HideInInspector]
		[FormerlySerializedAs("ropeWidthsData")]
		[Obsolete]
		public List<RopeWidthData> ropeWidthsData_;

		[FormerlySerializedAs("useNearColors")]
		[HideInInspector]
		[Obsolete]
		public bool useNearColors_;

		[FormerlySerializedAs("useCustomNearColors")]
		[HideInInspector]
		[Obsolete]
		public bool useCustomNearColors_;

		[HideInInspector]
		[FormerlySerializedAs("customNearColors")]
		[Obsolete]
		public List<Color> customNearColors_;

		[FormerlySerializedAs("MapId")]
		[HideInInspector]
		[Obsolete]
		public int MapId_;

		[Obsolete]
		[HideInInspector]
		[FormerlySerializedAs("HasMoveCount")]
		public bool HasMoveCount_;

		[Obsolete]
		[FormerlySerializedAs("MoveCount")]
		[HideInInspector]
		public int MoveCount_;

		[HideInInspector]
		[FormerlySerializedAs("HasTimeLimit")]
		[Obsolete]
		public bool HasTimeLimit_;

		[Obsolete]
		[HideInInspector]
		[FormerlySerializedAs("TimeLimit")]
		public int TimeLimit_;

		[Obsolete]
		[HideInInspector]
		[FormerlySerializedAs("Difficulty")]
		public string Difficulty_;

		public LevelCreatorSaveData()
		{
		}

		public LevelCreatorSaveData(LevelCreatorSaveData copy)
		{
		}

		public override string ToJson()
		{
			return null;
		}

		public static LevelCreatorSaveData FromJson(string json)
		{
			return null;
		}

		public override object Clone()
		{
			return null;
		}

		public LevelCreatorSaveData GetValidated()
		{
			return null;
		}

		private static LevelCreatorSaveData DoStagesMigration(LevelCreatorSaveData data)
		{
			return null;
		}

		private static LevelCreatorSaveData DoRopeColorsMigration(LevelCreatorSaveData data)
		{
			return null;
		}
	}
}
