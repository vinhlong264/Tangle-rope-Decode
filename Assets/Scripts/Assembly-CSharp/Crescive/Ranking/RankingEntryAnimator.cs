using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Ranking
{
	public class RankingEntryAnimator : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CAnimateIncreaseScoreRoutine_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RankingEntryAnimator _003C_003E4__this;

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
			public _003CAnimateIncreaseScoreRoutine_003Ed__11(int _003C_003E1__state)
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
		private RankingEntry rankingEntry;

		[SerializeField]
		private TMP_Text scoreTmp;

		[SerializeField]
		private FloatReference changeAmount;

		[SerializeField]
		private float increaseRankDuration;

		[SerializeField]
		private Ease increaseRankEase;

		[SerializeField]
		private float increaseRankScale;

		[SerializeField]
		private float increaseRankScaleDuration;

		[SerializeField]
		private Ease increaseRankScaleEase;

		public UnityEvent<float> OnAnimateIncreaseScore;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		[IteratorStateMachine(typeof(_003CAnimateIncreaseScoreRoutine_003Ed__11))]
		private IEnumerator AnimateIncreaseScoreRoutine()
		{
			return null;
		}

		private void OnDataSetCallback()
		{
		}
	}
}
