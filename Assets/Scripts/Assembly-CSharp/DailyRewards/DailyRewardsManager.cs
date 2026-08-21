using Crescive.Sequencer;
using CresciveCore;
using UnityEngine;

namespace DailyRewards
{
	public class DailyRewardsManager : MonoBehaviour
	{
		public static DailyRewardsManager Instance;

		private DailyRewardsRemote dailyRewardsRemote;

		public LevelSystem LevelSystem;

		public DailyRewardsPopup DailyRewardsPopup;

		public SequencerChannel returnedHomeSequencerChannel;

		private int extraTestDay;

		private bool firstTimeChecked;

		public DailyRewardsRemote DailyRewardsRemote => null;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnReturnedHome()
		{
		}

		private void OnDailyRewardsMenuButtonClicked(DailyRewardsEvents.OnDailyRewardsMenuButtonClicked p)
		{
		}

		private void OnMonthlyProgressionClaimed(DailyRewardsEvents.OnMonthlyProgressionClaimed p)
		{
		}

		private void OnDayClaimed(DailyRewardsEvents.OnDayClaimed p)
		{
		}

		private void OnTutorialCompleted()
		{
		}

		private void CheckDailyRewardsPopup()
		{
		}

		private void UpdateUI()
		{
		}

		public void Pass1Day()
		{
		}

		public void Pass2Day()
		{
		}

		public void Add7MonthlyProgression()
		{
		}

		public void ResetAll()
		{
		}
	}
}
