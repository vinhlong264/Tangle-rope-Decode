using RSG;

namespace Crescive.RaceSystem
{
	public class RaceServiceLocalBackend
	{
		private RaceServiceLocalBackendDatabase Database { get; }

		public RaceServiceLocalBackend(RaceServiceLocalBackendDatabase database)
		{
		}

		private IPromise<RaceStatus> GetRaceStatusSafe()
		{
			return null;
		}

		public IPromise<object> GetRaceStatus()
		{
			return null;
		}

		private IPromise<object> GetRaceUnavailableStatus()
		{
			return null;
		}

		private IPromise<object> GetNewRaceOfferStatus()
		{
			return null;
		}

		private IPromise<object> GetRaceOngoingStatus()
		{
			return null;
		}

		private IPromise<object> GetRaceFinishedStatus()
		{
			return null;
		}

		public IPromise<object> GetRaceData()
		{
			return null;
		}

		public IPromise<object> GetOpponentRacers()
		{
			return null;
		}

		public IPromise<object> GetPlayerRacer()
		{
			return null;
		}

		public IPromise<object> PostNewRaceAccepted()
		{
			return null;
		}

		public IPromise<object> PostNewRaceDeclined()
		{
			return null;
		}

		public IPromise<object> PostRaceFinishConfirmed()
		{
			return null;
		}

		private IPromise CheckAndUpdateRaceCount()
		{
			return null;
		}

		private IPromise PrepareForNewRace()
		{
			return null;
		}

		private IPromise UpdateOpponentRacersForCurrentRace()
		{
			return null;
		}

		public IPromise IncreasePlayerRacerCompletion(int amount)
		{
			return null;
		}
	}
}
