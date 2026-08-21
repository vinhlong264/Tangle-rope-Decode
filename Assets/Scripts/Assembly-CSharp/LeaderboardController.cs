using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using MyBox;
using UnityEngine;
using UnityEngine.Events;

public class LeaderboardController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCo_Animate_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool withDelay;

		public LeaderboardController _003C_003E4__this;

		private float _003CcurrentValue_003E5__2;

		private float _003CstartTime_003E5__3;

		private List<LeaderboardRecord> _003CupRecords_003E5__4;

		private int _003CcurrentPlayerRank_003E5__5;

		private int _003CupdatingPlayerRank_003E5__6;

		private int _003CrandomRankUpAmount_003E5__7;

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
		public _003CCo_Animate_003Ed__23(int _003C_003E1__state)
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

	[Header("References")]
	[SerializeField]
	private GameObject panelParent;

	[SerializeField]
	private RectTransform recordsParent;

	[SerializeField]
	private LeaderboardRecord playerRecord;

	[SerializeField]
	private RandomNames randomNames;

	[Header("Settings")]
	[SerializeField]
	private int startRank;

	[SerializeField]
	private MinMaxInt rankUpAmount;

	[SerializeField]
	private float startDelay;

	[SerializeField]
	private float recordTopStartEndPos;

	[SerializeField]
	private float recordsSpacing;

	[SerializeField]
	[Header("Animation Settings")]
	private float rankUpDuration;

	[SerializeField]
	private float rankUpSpeed;

	[SerializeField]
	private float playerRecordScaleUp;

	[SerializeField]
	private float playerRecordAnimDuration;

	[SerializeField]
	private float recordsMoveBelowPlayerDuration;

	[SerializeField]
	private Ease rankUpEase;

	[Header("Events")]
	[SerializeField]
	private UnityEvent OnPlayerRecordPlaced;

	private List<LeaderboardRecord> leaderboardRecords;

	private Coroutine animationCoroutine;

	private int CurrentPlayerRank
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CCo_Animate_003Ed__23))]
	private IEnumerator Co_Animate(bool withDelay)
	{
		return null;
	}

	public void StartAnimation(bool withDelay)
	{
	}
}
