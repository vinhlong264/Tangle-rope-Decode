using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Crescive.Navigation;
using UnityEngine;

namespace Crescive.LiveEvents.DynamicQuest
{
	public class DynamicQuestClaimPopupController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CClaimRoutine_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DynamicQuestClaimPopupController _003C_003E4__this;

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
			public _003CClaimRoutine_003Ed__10(int _003C_003E1__state)
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
		private Navigatable navigatable;

		[SerializeField]
		private DynamicQuestSystem dynamicQuestSystem;

		[SerializeField]
		private DynamicQuestProgressBarChannel progressBarChannel;

		[SerializeField]
		private DynamicQuestTokenClaimViewController tokenClaimView;

		[SerializeField]
		private DynamicQuestRewardClaimViewController rewardClaimView;

		[SerializeField]
		private float startDelay;

		[SerializeField]
		private float rewardsDelay;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SetupViews()
		{
		}

		[IteratorStateMachine(typeof(_003CClaimRoutine_003Ed__10))]
		private IEnumerator ClaimRoutine()
		{
			return null;
		}

		private void SetupRewardClaimView()
		{
		}

		private void ClaimTokensAndPopSelf(List<string> _ = null)
		{
		}

		private void OnShowCallback()
		{
		}
	}
}
