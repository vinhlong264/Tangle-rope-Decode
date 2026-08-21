using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Crescive.Sequencer
{
	[DefaultExecutionOrder(1)]
	public class HomeMenuPlayButtonSequenceChannelsListener : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDelayedButtonOpen_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public HomeMenuPlayButtonSequenceChannelsListener _003C_003E4__this;

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
			public _003CDelayedButtonOpen_003Ed__5(int _003C_003E1__state)
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
		private CanvasGroup playButtonCanvasGroup;

		private WaitForSeconds waitForSeconds;

		private Coroutine delayedStartRoutine;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		[IteratorStateMachine(typeof(_003CDelayedButtonOpen_003Ed__5))]
		private IEnumerator DelayedButtonOpen()
		{
			return null;
		}
	}
}
