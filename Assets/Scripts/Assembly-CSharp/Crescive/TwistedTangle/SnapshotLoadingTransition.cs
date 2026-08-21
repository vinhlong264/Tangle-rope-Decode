using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BrunoMikoski.AnimationSequencer;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Crescive.TwistedTangle
{
	public class SnapshotLoadingTransition : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CTransitionNumerator_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SnapshotLoadingTransition _003C_003E4__this;

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
			public _003CTransitionNumerator_003Ed__10(int _003C_003E1__state)
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
		private float delay;

		[SerializeField]
		private Image image;

		[SerializeField]
		private AnimationSequencerController sequencer;

		public UnityEvent OnBeforeStart;

		public UnityEvent OnAfterStart;

		public UnityEvent OnBeforeEnd;

		public UnityEvent OnAfterEnd;

		private Texture2D screenshotTexture;

		public void LoadingStarted()
		{
		}

		public void LoadingEnded()
		{
		}

		[IteratorStateMachine(typeof(_003CTransitionNumerator_003Ed__10))]
		private IEnumerator TransitionNumerator()
		{
			return null;
		}
	}
}
