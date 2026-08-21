using System;
using Crescive.DataService;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.League
{
	[CreateAssetMenu(fileName = "LiveLeagueDataService", menuName = "Crescive/League/LiveLeagueDataService")]
	public class LiveLeagueDataService : DataReadService<LiveLeagueSettings>
	{
		[SerializeField]
		private PersistentLiveLeagueData savedLeagueData;

		[SerializeField]
		private BoolVariable isLeagueEnabled;

		[SerializeField]
		private AtomCondition isAllUniqueLevelsCompleted;

		public UnityEvent OnNewLeagueActivated;

		public UnityEvent OnEnteredLeague;

		public UnityEvent OnExitedLeague;

		public UnityEvent OnLeagueFinished;

		public int CurrentLeagueRoundNumber => 0;

		public float TotalProgress => 0f;

		public float LocalProgress => 0f;

		public float CurrentLocalStartCatchUpPercent => 0f;

		public bool IsPlayingOnLeague => false;

		public PersistentLiveLeagueData SavedLeagueData => null;

		public bool IsLeagueActive => false;

		public bool IsEnteredLeague => false;

		protected override LiveLeagueSettings GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(LiveLeagueSettings plainData)
		{
			return false;
		}

		private void ActivateLeague()
		{
		}

		private void FinishLeague()
		{
		}

		private void EnterLeague()
		{
		}

		private void ExitLeague()
		{
		}

		private void TryActivateLeague()
		{
		}

		private void TryFinishingLeague()
		{
		}

		private void TryEnteringLeague()
		{
		}

		private void TryExitLeague()
		{
		}

		private bool CanActivateLeague()
		{
			return false;
		}

		private bool CanFinishLeague()
		{
			return false;
		}

		private bool CanEnterLeague()
		{
			return false;
		}

		private bool CanExitLeague()
		{
			return false;
		}

		private void SaveLeague()
		{
		}

		private float GetLeagueLocalEnterCatchUpPercent()
		{
			return 0f;
		}

		private void TryIncreasingLeagueRoundNumber()
		{
		}

		public int CalculateMaxScoreBasedOnLeagueEnter()
		{
			return 0;
		}

		public LeagueProgressData CalculateCurrentProgressData()
		{
			return default(LeagueProgressData);
		}

		public LeagueProgressData CalculateProgressDataByDate(DateTime date)
		{
			return default(LeagueProgressData);
		}

		public void SyncOnAppStart()
		{
		}

		public void SyncOnLeagueLevelCompleted()
		{
		}

		public void SyncOnEndDateExpiredInHomeScene()
		{
		}

		public void SyncOnLoadingHomeStarted()
		{
		}

		public void UpdateDateToToday()
		{
		}

		public void UpdateLeagueNumberAndFinishInMinutes(int minutes = 15)
		{
		}
	}
}
