using System.Collections.Generic;
using UnityEngine;

namespace Crescive.CreatorMode.Extensions
{
	public static class LevelCreatorSaveDataExtensions
	{
		private const float PinSearchDistance = 0.25f;

		private static readonly float PinSearchDistanceSqr;

		public static PinData GetNearbyPin(this LevelCreatorSaveData.StageData data, Vector3 pos)
		{
			return null;
		}

		public static bool IsCloseToPin(this LevelCreatorSaveData.StageData data, PinData pinData, Vector3 pos)
		{
			return false;
		}

		public static bool IsCloseToColumn(this LevelCreatorSaveData.StageData data, ColumnData columnData, Vector3 pos)
		{
			return false;
		}

		public static bool ArePositionsClose(this LevelCreatorSaveData.StageData data, Vector3 sourcePos, Vector3 targetPos)
		{
			return false;
		}

		public static bool HasAnyNearbyPin(this LevelCreatorSaveData.StageData data, Vector3 pos)
		{
			return false;
		}

		public static bool HasEmptySlot(this LevelCreatorSaveData.StageData data, Vector3 pos)
		{
			return false;
		}

		public static bool HasFilledSlot(this LevelCreatorSaveData.StageData data, Vector3 pos)
		{
			return false;
		}

		public static bool HasAnyNearbyColumn(this LevelCreatorSaveData.StageData data, Vector3 pos)
		{
			return false;
		}

		public static bool IsRopeConnectedToPin(this LevelCreatorSaveData.StageData data, PinData pinData, RopeData ropeData)
		{
			return false;
		}

		public static ColumnData GetNearbyColumn(this LevelCreatorSaveData.StageData data, Vector3 pos)
		{
			return null;
		}

		public static PinData GetRopeStartPin(this LevelCreatorSaveData.StageData data, RopeData ropeData)
		{
			return null;
		}

		public static PinData GetRopeEndPin(this LevelCreatorSaveData.StageData data, RopeData ropeData)
		{
			return null;
		}

		public static List<PinData> GetRopePins(this LevelCreatorSaveData.StageData data, RopeData ropeData)
		{
			return null;
		}

		public static List<PinData> GetPinsNearby(this LevelCreatorSaveData.StageData data, Vector3 pos)
		{
			return null;
		}

		public static List<ColumnData> GetColumnsInDistance(this LevelCreatorSaveData.StageData data, Vector3 pos)
		{
			return null;
		}

		public static List<RopeData> GetConnectedPinRopes(this LevelCreatorSaveData.StageData data, PinData pinData)
		{
			return null;
		}

		public static List<RopeWithPinsData> GetRopesWithPins(this LevelCreatorSaveData.StageData data)
		{
			return null;
		}

		public static List<RopeWithPinsData> GetRopesWithPinsExcludingSlot(this LevelCreatorSaveData.StageData data, Vector3 pos)
		{
			return null;
		}

		public static List<RopeWithPinsData> GetRopesWithPinsExcludingSlots(this LevelCreatorSaveData.StageData data, List<Vector3> positions)
		{
			return null;
		}

		public static int GetRopeIndex(this LevelCreatorSaveData.StageData data, RopeData ropeData)
		{
			return 0;
		}

		public static float GetFillPercentageOfSlots(this LevelCreatorSaveData.StageData data, List<Vector3> positions)
		{
			return 0f;
		}

		public static void AddRopeWithPins(this LevelCreatorSaveData.StageData data, RopeWithPinsData ropeWithPinsData)
		{
		}

		public static void AddRopesWithPins(this LevelCreatorSaveData.StageData data, List<RopeWithPinsData> ropesWithPinsData)
		{
		}

		public static void AddRope(this LevelCreatorSaveData.StageData data, RopeData ropeData)
		{
		}

		public static void AddRopes(this LevelCreatorSaveData.StageData data, List<RopeData> ropesData)
		{
		}

		public static void AddPin(this LevelCreatorSaveData.StageData data, PinData pinData)
		{
		}

		public static void AddPins(this LevelCreatorSaveData.StageData data, List<PinData> pinsData)
		{
		}

		public static void AddColumn(this LevelCreatorSaveData.StageData data, ColumnData columnData)
		{
		}

		public static void AddColumns(this LevelCreatorSaveData.StageData data, List<ColumnData> columnsData)
		{
		}
	}
}
