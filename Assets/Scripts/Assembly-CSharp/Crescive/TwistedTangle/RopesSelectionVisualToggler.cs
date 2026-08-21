using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class RopesSelectionVisualToggler : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDoActionNextFrameCoroutine_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Action callback;

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
			public _003CDoActionNextFrameCoroutine_003Ed__9(int _003C_003E1__state)
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
		private RopesChannel ropesChannel;

		private bool isActivated;

		private Coroutine nextFrameCallback;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnRopesChannelDataChanged()
		{
		}

		private void EnableHighlighters()
		{
		}

		private void DisableHighlighters()
		{
		}

		private void DoActionNextFrame(Action callback)
		{
		}

		[IteratorStateMachine(typeof(_003CDoActionNextFrameCoroutine_003Ed__9))]
		private IEnumerator DoActionNextFrameCoroutine(Action callback)
		{
			return null;
		}

		public void Activate()
		{
		}

		public void Deactivate()
		{
		}

		public void Toggle(bool active)
		{
		}
	}
}
