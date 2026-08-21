using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

namespace Crescive.LadderOffer
{
	public class LadderOfferViewAnimator : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass14_0
		{
			public LadderOfferItemView claimedItemView;

			internal bool _003CItemClaimedAnimationRoutine_003Eb__0()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003CItemClaimedAnimationRoutine_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LadderOfferItemView claimedItemView;

			public LadderOfferViewAnimator _003C_003E4__this;

			private _003C_003Ec__DisplayClass14_0 _003C_003E8__1;

			private List<LadderOfferItemView> _003CitemViews_003E5__2;

			private int _003Ccount_003E5__3;

			private int _003Ci_003E5__4;

			private LadderOfferItemView _003CitemView_003E5__5;

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
			public _003CItemClaimedAnimationRoutine_003Ed__14(int _003C_003E1__state)
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
		private LadderOfferView ladderOfferView;

		[SerializeField]
		private float claimDuration;

		[SerializeField]
		private float claimEndScale;

		[SerializeField]
		private Ease claimEase;

		[SerializeField]
		private float claimStartDelay;

		[SerializeField]
		private float claimEndDelay;

		[SerializeField]
		private float moveDuration;

		[SerializeField]
		private Ease moveEase;

		[SerializeField]
		private float moveDelayBetweenItems;

		[SerializeField]
		private float appearDuration;

		[SerializeField]
		private float appearStartScale;

		[SerializeField]
		private Ease appearEase;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		[IteratorStateMachine(typeof(_003CItemClaimedAnimationRoutine_003Ed__14))]
		private IEnumerator ItemClaimedAnimationRoutine(LadderOfferItemView claimedItemView)
		{
			return null;
		}

		private void OnItemClaimedCallback(LadderOfferItemView itemView)
		{
		}

		private void PlayClaimAnimation(LadderOfferItemView itemView)
		{
		}

		private void PlayMoveAnimation(LadderOfferItemView itemView, int index)
		{
		}
	}
}
