using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Crescive.GameStates;
using CresciveCore;
using UnityEngine;

namespace Crescive.UI
{
	public class GameMenu : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003COpenPanelDelayed_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public GameMenu _003C_003E4__this;

			public GameObject panel;

			public float duration;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003COpenPanelDelayed_003Ed__14(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[SerializeField]
		private LevelSystem levelSystem;

		[SerializeField]
		private GameStateEvents gameStateEvents;

		[SerializeField]
		private GameObject winPanel;

		[SerializeField]
		private GameObject gameOverPanel;

		[SerializeField]
		private float winPanelOpenDelay;

		[SerializeField]
		private float winPanelOpenDuration;

		[SerializeField]
		private float failPanelOpenDelay;

		[SerializeField]
		private float failPanelOpenDuration;

		private GameObject _activePanel;

		private bool _gameFinished;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void LoadNextLevel()
		{
		}

		public void RestartLevel()
		{
		}

		[IteratorStateMachine(typeof(_003COpenPanelDelayed_003Ed__14))]
		private IEnumerator OpenPanelDelayed(GameObject panel, float delay, float duration)
		{
			return null;
		}

		private void OpenPanel(GameObject panel, float duration)
		{
		}

		private void AnimatePanel(Transform panel, float duration)
		{
		}

		private void OnGameWin()
		{
		}

		private void OnGameOver()
		{
		}
	}
}
