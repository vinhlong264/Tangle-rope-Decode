using System;
using Crescive.GameStates;
using CresciveCore;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Analytics
{
	public class CresciveAnalyticsEventsListener : MonoBehaviour
	{
		[SerializeField]
		private LevelSystem levelSystem;

		[SerializeField]
		private GameStateEvents gameStateEvents;

		public UnityEvent<int> OnLevelStarted;

		public UnityEvent<int, string> OnLevelStartedWithUniqueId;

		public UnityEvent<int> OnLevelCompleted;

		public UnityEvent<int, string> OnLevelCompletedWithUniqueId;

		public UnityEvent<int> OnLevelFailed;

		public UnityEvent<int, string> OnLevelFailedWithUniqueId;

		private int currentLevelNumber;

		private string currentLevelIdString;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnPlayCallback()
		{
		}

		private void OnWinCallback()
		{
		}

		private void OnGameOverCallback()
		{
		}

		private void SendEvent(Action call)
		{
		}
	}
}
