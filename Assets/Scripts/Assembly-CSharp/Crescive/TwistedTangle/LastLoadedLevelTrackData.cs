using Crescive.CreatorMode;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	[CreateAssetMenu(fileName = "LastLoadedLevelTrackData", menuName = "GameData/Map/Last Loaded Level Track Data")]
	public class LastLoadedLevelTrackData : ScriptableObject
	{
		[SerializeField]
		private RopesChannel ropesChannel;

		[SerializeField]
		private LevelCreatorSaveData lastLoadedLevel;

		[SerializeField]
		private int initialConnectedRopeCount;

		[SerializeField]
		private int initialRopeCount;

		public LevelCreatorSaveData LastLoadedLevel => null;

		public int InitialConnectedRopeCount => 0;

		public int InitialRopeCount => 0;

		public int RemainingRopeCount => 0;

		public int RemainingConnectedRopeCount => 0;

		public float RemainingRopePercentage => 0f;

		public float RemainingConnectedRopePercentage => 0f;

		public float SolvedRopePercentage => 0f;

		public float SolvedConnectedRopePercentage => 0f;

		public void SetLastLoadedLevel(LevelCreatorSaveData level)
		{
		}
	}
}
