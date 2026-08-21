using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Crescive.LiveEvents.DynamicQuest;
using DG.Tweening;
using TMPro;
using UnityEngine;

namespace DynamicQuestTime
{
	public class DynamicQuestTimeTokenClaimViewController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CAnimate_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DynamicQuestTimeTokenClaimViewController _003C_003E4__this;

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
			public _003CAnimate_003Ed__36(int _003C_003E1__state)
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
		private sealed class _003CClaimRoutine_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DynamicQuestTimeTokenClaimViewController _003C_003E4__this;

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
			public _003CClaimRoutine_003Ed__32(int _003C_003E1__state)
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
		private DynamicQuestTokenClaimFx tokenClaimFxPrefab;

		[SerializeField]
		private RectTransform objectsParent;

		[SerializeField]
		private CanvasGroup canvasGroup;

		[SerializeField]
		private RectTransform tokenPivot;

		[SerializeField]
		private TextMeshProUGUI tokenText;

		[SerializeField]
		private CanvasGroup token;

		[SerializeField]
		private CanvasGroup multiplierToken;

		private Transform tokenParent;

		private Vector3 tokenStartPosition;

		private Vector3 tokenStartScale;

		private Vector3 multiplierTokenStartPosition;

		private Vector3 multiplierTokenStartScale;

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

		private int pendingToken;

		public CanvasGroup CanvasGroup => null;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnDynamicQuestTimeProgressBarTokenPosition(DynamicQuestTimeEvents.OnDynamicQuestTimeProgressBarTokenPosition p)
		{
		}

		[IteratorStateMachine(typeof(_003CClaimRoutine_003Ed__32))]
		private IEnumerator ClaimRoutine()
		{
			return null;
		}

		private Tween AnimateAppear(CanvasGroup token)
		{
			return null;
		}

		private Tween AnimateMultiplierToken(CanvasGroup token, CanvasGroup multiplierToken)
		{
			return null;
		}

		private Tween AnimateClaim(CanvasGroup token)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CAnimate_003Ed__36))]
		public IEnumerator Animate()
		{
			return null;
		}
	}
}
