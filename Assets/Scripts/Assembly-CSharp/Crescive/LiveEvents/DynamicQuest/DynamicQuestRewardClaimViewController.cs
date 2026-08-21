using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Crescive.UI;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Crescive.LiveEvents.DynamicQuest
{
	public class DynamicQuestRewardClaimViewController : BaseDynamicQuestPopupController
	{
		[CompilerGenerated]
		private sealed class _003CAnimate_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DynamicQuestRewardClaimViewController _003C_003E4__this;

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
			public _003CAnimate_003Ed__16(int _003C_003E1__state)
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
		private sealed class _003CClaimRoutine_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DynamicQuestRewardClaimViewController _003C_003E4__this;

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
			public _003CClaimRoutine_003Ed__11(int _003C_003E1__state)
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
		private CanvasGroup canvasGroup;

		[SerializeField]
		private DynamicQuestRewardsViewController rewardsView;

		[SerializeField]
		private Image titleFeatureImage;

		[SerializeField]
		private List<AnimatedPanel> animatedPanels;

		[SerializeField]
		private DynamicQuestRewardClaimViewArgs currentArgs;

		public UnityEvent OnAnimationEnd;

		public UnityEvent<List<string>> OnClaim;

		public CanvasGroup CanvasGroup => null;

		private float GetTotalAnimationDuration()
		{
			return 0f;
		}

		private void ResetRewards()
		{
		}

		[IteratorStateMachine(typeof(_003CClaimRoutine_003Ed__11))]
		private IEnumerator ClaimRoutine()
		{
			return null;
		}

		protected override void SyncBindingsInternal()
		{
		}

		protected override void ResetViewInternal()
		{
		}

		public void SetupArgs(DynamicQuestRewardClaimViewArgs args)
		{
		}

		public void OnShowArgs(DynamicQuestRewardClaimViewArgs args)
		{
		}

		[IteratorStateMachine(typeof(_003CAnimate_003Ed__16))]
		public IEnumerator Animate()
		{
			return null;
		}

		public void Claim()
		{
		}
	}
}
