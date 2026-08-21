using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CresciveCore.Utils;
using UnityEngine;
using UnityEngine.Events;

namespace CresciveCore.Managers
{
	public class LoadingUI : Singleton<LoadingUI>
	{
		[CompilerGenerated]
		private sealed class _003CUpdateLoading_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public bool activate;

			public LoadingUI _003C_003E4__this;

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
			public _003CUpdateLoading_003Ed__6(int _003C_003E1__state)
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
		private float loadingDelay;

		[SerializeField]
		private bool freezeTimeOnDelay;

		public UnityEvent LoadingStarted;

		public UnityEvent LoadingEnded;

		public void OnLoadingStarted()
		{
		}

		public void OnLoadingEnded()
		{
		}

		[IteratorStateMachine(typeof(_003CUpdateLoading_003Ed__6))]
		private IEnumerator UpdateLoading(bool activate)
		{
			return null;
		}
	}
}
