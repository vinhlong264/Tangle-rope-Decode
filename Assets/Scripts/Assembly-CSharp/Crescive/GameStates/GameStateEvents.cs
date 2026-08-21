using UnityEngine;
using UnityEngine.Events;

namespace Crescive.GameStates
{
	[CreateAssetMenu(menuName = "GameStateEvents", fileName = "GameStateEvents")]
	public class GameStateEvents : ScriptableObject
	{
		public UnityEvent OnIdle;

		public UnityEvent OnPlay;

		public UnityEvent OnPause;

		public UnityEvent OnWin;

		public UnityEvent OnGameOver;

		public void TriggerIdleEvent()
		{
		}

		public void TriggerPlayEvent()
		{
		}

		public void TriggerPauseEvent()
		{
		}

		public void TriggerWinEvent()
		{
		}

		public void TriggerGameOverEvent()
		{
		}

		public void TriggerWinWithPlayIfNotStartedEvent()
		{
		}

		public void TriggerPlayIfNotStarted()
		{
		}
	}
}
