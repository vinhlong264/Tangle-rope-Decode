using Crescive.HelperTypes;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.GameStates
{
	public class GameStateEventsListener : MonoBehaviour
	{
		[SerializeField]
		private GameStateEvents gameStateEvents;

		[SerializeField]
		private AutoTriggerMethod autoTriggerMethod;

		public UnityEvent OnGameIdleEvent;

		public UnityEvent OnGameStartedEvent;

		public UnityEvent OnGamePausedEvent;

		public UnityEvent OnGameFinishedEvent;

		public UnityEvent OnGameWinEvent;

		public UnityEvent OnGameOverEvent;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		private void TriggerEvents()
		{
		}

		protected virtual void OnGameIdle()
		{
		}

		protected virtual void OnGameStarted()
		{
		}

		protected virtual void OnGamePaused()
		{
		}

		protected virtual void OnGameWin()
		{
		}

		protected virtual void OnGameOver()
		{
		}

		protected virtual void OnGameFinished()
		{
		}
	}
}
