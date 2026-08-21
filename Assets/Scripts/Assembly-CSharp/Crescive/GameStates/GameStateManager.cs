using CresciveCore;
using CresciveCore.Utils;
using UnityEngine;

namespace Crescive.GameStates
{
	public class GameStateManager : Singleton<GameStateManager>
	{
		[SerializeField]
		private LoaderChannel loaderChannel;

		[SerializeField]
		private GameStateEvents gameStateEvents;

		private bool started;

		private bool finished;

		private bool won;

		public bool Finished => false;

		public bool Started => false;

		public bool Won => false;

		public bool IsIdle => false;

		public bool IsStarted => false;

		public bool IsWin => false;

		public bool IsGameOver => false;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Play()
		{
		}

		public void Win()
		{
		}

		public void GameOver()
		{
		}

		private void OnIdle()
		{
		}

		private void OnPlay()
		{
		}

		private void OnPause()
		{
		}

		private void OnWin()
		{
		}

		private void OnGameOver()
		{
		}
	}
}
