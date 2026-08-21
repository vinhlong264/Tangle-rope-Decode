using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace Crescive.TwistedTangle
{
	public class MoveCountCompareListener : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCheckForMoveCountCoroutine_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MoveCountCompareListener _003C_003E4__this;

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
			public _003CCheckForMoveCountCoroutine_003Ed__8(int _003C_003E1__state)
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
		private IntVariable currentMoveCount;

		[SerializeField]
		private IntReference targetMoveCount;

		[FormerlySerializedAs("OnReachMoveCount")]
		public UnityEvent OnEqualToMoveCount;

		public UnityEvent OnLessThanMoveCount;

		public UnityEvent OnMoreThanMoveCount;

		public UnityEvent OnLessThanOrEqualToMoveCount;

		public UnityEvent OnMoreThanOrEqualToMoveCount;

		public void OnMoved()
		{
		}

		[IteratorStateMachine(typeof(_003CCheckForMoveCountCoroutine_003Ed__8))]
		private IEnumerator CheckForMoveCountCoroutine()
		{
			return null;
		}

		private void CheckForMoveCount()
		{
		}
	}
}
