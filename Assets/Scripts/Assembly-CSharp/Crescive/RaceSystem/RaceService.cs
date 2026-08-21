using System.Collections.Generic;
using RSG;
using UnityEngine;

namespace Crescive.RaceSystem
{
	[CreateAssetMenu(fileName = "RaceService", menuName = "Crescive/Race System/Core/RaceService")]
	public class RaceService : ScriptableObject
	{
		[field: SerializeField]
		[field: Header("Read")]
		public RaceSettingsDataReadService RaceSettingsDataRead { get; private set; }

		[field: SerializeField]
		public RaceStatusDataReadService RaceStatusDataRead { get; private set; }

		[field: SerializeField]
		public RaceDataReadService RaceDataRead { get; private set; }

		[field: SerializeField]
		public RacerDataReadService PlayerRacerRead { get; private set; }

		[field: SerializeField]
		public NpcRacersDataReadService OpponentRacersRead { get; private set; }

		[field: SerializeField]
		[field: Header("Post")]
		public NewRaceAcceptedPostService NewRaceAcceptedPost { get; private set; }

		[field: SerializeField]
		public NewRaceDeclinedPostService NewRaceDeclinedPost { get; private set; }

		[field: SerializeField]
		public RaceFinishConfirmedPostService RaceFinishConfirmed { get; private set; }

		public IPromise<RaceSettingsData> GetRaceSettings()
		{
			return null;
		}

		public IPromise<RaceStatusData> GetRaceStatus()
		{
			return null;
		}

		public IPromise<RaceData> GetRaceData()
		{
			return null;
		}

		public IPromise<RacerData> GetPlayerRacerData()
		{
			return null;
		}

		public IPromise<RaceData> PostNewRaceAccepted()
		{
			return null;
		}

		public IPromise PostNewRaceDeclined()
		{
			return null;
		}

		public IPromise PostRaceFinishConfirmed()
		{
			return null;
		}

		public IPromise<int> GetPlayerRankAsync()
		{
			return null;
		}

		public IPromise<List<RacerData>> GetRacersOrdered()
		{
			return null;
		}

		public IPromise<float> GetRaceRemainingTimeAsync()
		{
			return null;
		}
	}
}
