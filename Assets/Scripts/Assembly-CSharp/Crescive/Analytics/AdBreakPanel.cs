using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Crescive.Ads;
using UnityAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Analytics
{
	public class AdBreakPanel : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CAdBreakFinishedRoutine_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AdBreakPanel _003C_003E4__this;

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
			public _003CAdBreakFinishedRoutine_003Ed__16(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CAdBreakTriggeredRoutine_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AdBreakPanel _003C_003E4__this;

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
			public _003CAdBreakTriggeredRoutine_003Ed__15(int _003C_003E1__state)
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
		private CresciveAdsEvents adsEvents;

		[SerializeField]
		private CanvasGroup mainPanel;

		[SerializeField]
		private GameObject adBreakStartPanel;

		[SerializeField]
		private GameObject adBreakFinishPanel;

		[SerializeField]
		private float adBreakStartDelay;

		[SerializeField]
		private float adBreakCloseDelay;

		[Header("Conditions")]
		[SerializeField]
		private AtomCondition interstitialActiveCondition;

		private bool isAdBreakInProgress;

		public UnityEvent OnAdBreakTriggered;

		public UnityEvent OnAdBreakBeforeStart;

		public UnityEvent OnAdBreakFinished;

		private bool CanTrigger => false;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		[IteratorStateMachine(typeof(_003CAdBreakTriggeredRoutine_003Ed__15))]
		private IEnumerator AdBreakTriggeredRoutine()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CAdBreakFinishedRoutine_003Ed__16))]
		private IEnumerator AdBreakFinishedRoutine()
		{
			return null;
		}

		private void OnInterstitialFinishedCallback()
		{
		}

		public void TriggerAdBreak()
		{
		}
	}
}
