using CresciveCore;
using PersistentSO;
using RSG;
using UnityEngine;

namespace Crescive.RaceSystem
{
	[CreateAssetMenu(fileName = "RaceServiceLocalBackendDatabase", menuName = "Crescive/Race System/Local Backend/RaceServiceLocalBackendDatabase")]
	public class RaceServiceLocalBackendDatabase : ScriptableObject
	{
		[SerializeField]
		[Header("Data Sources")]
		public RaceDataPersistentVariable raceDataPersistent;

		[SerializeField]
		public RacerDataPersistentVariable playerRacerDataPersistent;

		[SerializeField]
		public NpcRacersDataPersistentVariable opponentRacersDataPersistent;

		[SerializeField]
		private RaceSettingsDataReadService raceSettingsDataRead;

		[SerializeField]
		private LevelSystem levelSystem;

		[SerializeField]
		public PersistentIntVariable lastLevelNumberPlayerCompletion;

		[field: SerializeField]
		[field: Header("Settings")]
		public AnimationCurve OpponentCompletionCurve { get; private set; }

		public IPromise<RaceData> GetRaceData()
		{
			return null;
		}

		public IPromise<RaceData> SetRaceData(RaceData value)
		{
			return null;
		}

		public IPromise<RacerData> GetPlayerRacerData()
		{
			return null;
		}

		public IPromise<RacerData> SetPlayerRacerData(RacerData value)
		{
			return null;
		}

		public IPromise<NpcRacersData> GetOpponentRacersData()
		{
			return null;
		}

		public IPromise<NpcRacersData> SetOpponentRacersData(NpcRacersData value)
		{
			return null;
		}

		public IPromise<RaceSettingsData> GetRaceSettings()
		{
			return null;
		}

		public IPromise SyncLastLevelNumberPlayerCompletionToCurrentLevelNumber()
		{
			return null;
		}

		public int GetLevelNumber()
		{
			return 0;
		}
	}
}
