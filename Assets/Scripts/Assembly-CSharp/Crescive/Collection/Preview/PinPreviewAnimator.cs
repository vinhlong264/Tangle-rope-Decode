using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Crescive.TwistedTangle;
using DG.Tweening;
using UnityEngine;

namespace Crescive.Collection.Preview
{
	public class PinPreviewAnimator : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CGetReadyCoroutine_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PinPreviewAnimator _003C_003E4__this;

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
			public _003CGetReadyCoroutine_003Ed__7(int _003C_003E1__state)
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
		private PinEntity pinEntity;

		[SerializeField]
		private float jumpPower;

		[SerializeField]
		private float jumpDuration;

		[SerializeField]
		private Ease jumpEase;

		private bool isReady;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		[IteratorStateMachine(typeof(_003CGetReadyCoroutine_003Ed__7))]
		private IEnumerator GetReadyCoroutine()
		{
			return null;
		}

		public void OnCollectionItemChanged()
		{
		}
	}
}
