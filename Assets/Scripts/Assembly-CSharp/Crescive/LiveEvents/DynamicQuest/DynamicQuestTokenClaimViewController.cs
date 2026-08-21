using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

namespace Crescive.LiveEvents.DynamicQuest
{
	public class DynamicQuestTokenClaimViewController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CAnimate_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DynamicQuestTokenClaimViewController _003C_003E4__this;

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
			public _003CAnimate_003Ed__27(int _003C_003E1__state)
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
		private sealed class _003CClaimRoutine_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DynamicQuestTokenClaimViewController _003C_003E4__this;

			private DynamicQuestTokenClaimFx _003Ctoken_003E5__2;

			private TokenView _003CmultiplierToken_003E5__3;

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
			public _003CClaimRoutine_003Ed__22(int _003C_003E1__state)
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
		private DynamicQuestSystem dynamicQuestSystem;

		[SerializeField]
		private DynamicQuestProgressBarChannel progressBarChannel;

		[SerializeField]
		private DynamicQuestTokenClaimFx tokenClaimFxPrefab;

		[SerializeField]
		private TokenView multiplierTokenPrefab;

		[SerializeField]
		private RectTransform objectsParent;

		[SerializeField]
		private CanvasGroup canvasGroup;

		[SerializeField]
		private float startDelay;

		[SerializeField]
		private float endDelay;

		[SerializeField]
		private float tokenPunchScale;

		[SerializeField]
		private float tokenAppearDuration;

		[SerializeField]
		private float multiplierTokenAppearDelay;

		[SerializeField]
		private Vector2 multiplierTokenOffset;

		[SerializeField]
		private float curveMoveStrength;

		[SerializeField]
		private float multiplierAnimateDuration;

		[SerializeField]
		private Ease multiplierAnimateEase;

		[SerializeField]
		private float tokenClaimDelay;

		[SerializeField]
		private float tokenClaimMoveDuration;

		[SerializeField]
		private float tokenClaimDuration;

		[SerializeField]
		private float tokenClaimCurveMoveStrength;

		[SerializeField]
		private Ease tokenClaimEase;

		public CanvasGroup CanvasGroup => null;

		[IteratorStateMachine(typeof(_003CClaimRoutine_003Ed__22))]
		private IEnumerator ClaimRoutine()
		{
			return null;
		}

		private Tween AnimateAppear(DynamicQuestTokenClaimFx token)
		{
			return null;
		}

		private Tween AnimateMultiplierToken(DynamicQuestTokenClaimFx token, TokenView multiplierToken)
		{
			return null;
		}

		private Tween AnimateClaim(DynamicQuestTokenClaimFx token)
		{
			return null;
		}

		private void GetTokenViews(out DynamicQuestTokenClaimFx token, out TokenView multiplierToken)
		{
			token = null;
			multiplierToken = null;
		}

		[IteratorStateMachine(typeof(_003CAnimate_003Ed__27))]
		public IEnumerator Animate()
		{
			return null;
		}
	}
}
