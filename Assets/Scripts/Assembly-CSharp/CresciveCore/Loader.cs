using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CresciveCore.Utils;
using DevLocker.Utils;
using UnityEngine;
using UnityEngine.Events;

namespace CresciveCore
{
	[DefaultExecutionOrder(-99999999)]
	public class Loader : Singleton<Loader>
	{
		[CompilerGenerated]
		private sealed class _003CDoNextFrameEnumerator_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Action action;

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
			public _003CDoNextFrameEnumerator_003Ed__26(int _003C_003E1__state)
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
		private LoaderChannel loaderChannel;

		[SerializeField]
		private SceneField homeScene;

		[SerializeField]
		private float loadStartDelay;

		[SerializeField]
		private bool randomizeLoadLevelOnRecycle;

		[SerializeField]
		private List<SceneField> extraScenes;

		private bool isLoading;

		[Space]
		public UnityEvent OnLoadingRequested;

		public UnityEvent OnLoadingStarted;

		public UnityEvent OnLoadingFinished;

		public UnityEvent OnLoadedSceneReady;

		public UnityEvent OnLoadingOtherSceneStarted;

		public UnityEvent OnLoadingOtherSceneFinished;

		public UnityEvent OnLoadingHomeStarted;

		public UnityEvent OnLoadingHomeFinished;

		public UnityEvent OnLoadLastLeveRequested;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		protected override void OnInstanceCreated()
		{
		}

		protected override void OnInstanceDestroyed()
		{
		}

		private void Load(Action action, bool delayed = true)
		{
		}

		private void PerformLoad(Action action)
		{
		}

		private void LoadRequested()
		{
		}

		private void LoadStarted()
		{
		}

		private void LoadFinished()
		{
		}

		private void DoNextFrame(Action action)
		{
		}

		[IteratorStateMachine(typeof(_003CDoNextFrameEnumerator_003Ed__26))]
		private IEnumerator DoNextFrameEnumerator(Action action)
		{
			return null;
		}

		private void OnLevelSystemLoadFinished(LevelData data)
		{
		}

		public void LoadNextLevel(bool delayed)
		{
		}

		public void LoadPreviousLevel(bool delayed)
		{
		}

		public void LoadLevel(int levelNumber, bool delayed)
		{
		}

		public void LoadLevelWithId(int levelId, bool delayed)
		{
		}

		public void LoadHome(bool delayed)
		{
		}

		public void LoadLastSavedLevel(bool delayed)
		{
		}

		public void RestartLevel(bool delayed)
		{
		}

		public bool IsHomeMenuActive()
		{
			return false;
		}

		public void LoadScene(SceneReference scene)
		{
		}

		public void LoadScene(string sceneName)
		{
		}

		public void LoadScene(string sceneName, bool delayed)
		{
		}

		public void LoadExtraScene(int extraSceneIndex)
		{
		}
	}
}
