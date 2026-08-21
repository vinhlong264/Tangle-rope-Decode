using PersistentSO;
using UnityEngine;

namespace Crescive.League
{
	[CreateAssetMenu(fileName = "PersistentLiveLeagueData", menuName = "Crescive/League/PersistentLiveLeagueData")]
	public class PersistentLiveLeagueData : PersistentVariable<LiveLeagueSaveData>
	{
		public override LiveLeagueSaveData GetCopy(LiveLeagueSaveData value)
		{
			return null;
		}

		public void SetSettings(LiveLeagueSettings settings)
		{
		}

		public void SetIsActive(bool isActive)
		{
		}

		public void SetIsEntered(bool isEntered)
		{
		}

		public void SetEnterDate(string enterDate)
		{
		}

		public void SetCurrentRoundNumber(int currentRoundNumber)
		{
		}

		public void SetTotalCompletedRoundCount(int totalCompletedRoundNumber)
		{
		}

		public void SetFinishDate(string finishDate)
		{
		}

		public void SetLeagueNumber(int leagueNumber)
		{
		}

		public void UpdateOnLeagueActivated()
		{
		}

		public void UpdateOnLeagueFinished()
		{
		}

		public void UpdateOnLeagueEntered()
		{
		}

		public void UpdateOnLeagueExited()
		{
		}

		public void UpdateOnLeagueRoundCompleted()
		{
		}
	}
}
