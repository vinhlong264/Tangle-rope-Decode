using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ElephantSocial.Model;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TournamentNotificationController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CUpdateRoutine_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TournamentNotificationController _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public _003CUpdateRoutine_003Ed__12(int _003C_003E1__state)
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
	private GameObject indicator;

	[SerializeField]
	private GameObject textParent;

	[SerializeField]
	private TMP_Text text;

	[SerializeField]
	private List<ContentSizeFitter> fitter;

	[SerializeField]
	private RectTransform layoutGroup;

	private Coroutine _updateRoutine;

	private float _defaultTextSize;

	private int tournamentId => 0;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateRoutine_003Ed__12))]
	private IEnumerator UpdateRoutine()
	{
		return null;
	}

	private void OnBoardUpdated()
	{
	}

	private void OnBoardUpdated(int _)
	{
	}

	private void CheckBoard(CachedBoard board)
	{
	}

	private void CloseInfo()
	{
	}

	private int FindMyRank(List<BoardPlayer> players, string mySocialId)
	{
		return 0;
	}

	private void SetText(int pendingType, int rank1Based = 0)
	{
	}

	private static string PlaceToOrdinal(int n)
	{
		return null;
	}
}
