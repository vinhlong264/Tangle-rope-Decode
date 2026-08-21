using System;
using CresciveCore;
using UnityEngine;

namespace DynamicQuestTime
{
	[DefaultExecutionOrder(int.MinValue)]
	public class DynamicQuestTimeManager : MonoBehaviour
	{
		public static DynamicQuestTimeManager Instance;

		private DynamicQuestTimeData dynamicQuestData;

		private DynamicQuestTimeRemote dynamicQuestTimeRemote;

		public LevelSystem LevelSystem;

		private bool firstTimeChecked;

		public bool IsAlive;

		public static DynamicQuestTimeData DynamicQuestData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DynamicQuestTimeRemote DynamicQuestTimeRemote => null;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnCheckDynamicQuestTimeUI(DynamicQuestTimeEvents.OnCheckDynamicQuestTimeUI p)
		{
		}

		private void OnHomeButtonClicked(DynamicQuestTimeEvents.OnHomeButtonClicked p)
		{
		}

		private void OnReturnedHome()
		{
		}

		private void CheckDynamicQuestTimePopup()
		{
		}

		private void OnDynamicQuestActivated()
		{
		}

		private void OnDynamicQuestDeactivated()
		{
		}

		public void OnPendingTokenAdded()
		{
		}

		public void OnQuestStepCompleted(int step)
		{
		}

		public bool IsInEventDays()
		{
			return false;
		}

		public TimeSpan GetRemainingTimeSpan()
		{
			return default(TimeSpan);
		}

		public void AddProgress(int progress)
		{
		}

		public RewardList GetRewardsWithPlusProgress(int lastProgression, int currentProgression)
		{
			return null;
		}

		public int GetRewardIndex(int progression, out bool isCompleted)
		{
			isCompleted = default(bool);
			return 0;
		}

		internal void SetClaimed()
		{
		}
	}
}
