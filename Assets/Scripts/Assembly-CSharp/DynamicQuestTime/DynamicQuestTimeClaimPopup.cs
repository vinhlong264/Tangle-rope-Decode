using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Crescive.Navigation;
using UnityEngine;

namespace DynamicQuestTime
{
	public class DynamicQuestTimeClaimPopup : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CAnimate_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DynamicQuestTimeClaimPopup _003C_003E4__this;

			private int _003ClastProgress_003E5__2;

			private int _003CcurrentProgress_003E5__3;

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
			public _003CAnimate_003Ed__8(int _003C_003E1__state)
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
		private GameObject main;

		[SerializeField]
		private Navigatable navigatable;

		[SerializeField]
		private DynamicQuestTimeTokenClaimViewController dynamicQuestTimeTokenClaimViewController;

		[SerializeField]
		private RewardDisplayer rewardDisplayer;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnDynamicQuestTimeClaimPopupOpen(DynamicQuestTimeEvents.OnDynamicQuestTimeClaimPopupOpen p)
		{
		}

		public void OpenUI()
		{
		}

		[IteratorStateMachine(typeof(_003CAnimate_003Ed__8))]
		private IEnumerator Animate()
		{
			return null;
		}

		private void RewardsClaimed()
		{
		}

		public void CloseUI()
		{
		}
	}
}
