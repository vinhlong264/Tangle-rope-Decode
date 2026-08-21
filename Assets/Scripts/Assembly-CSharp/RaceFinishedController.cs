using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Crescive.Navigation;
using Crescive.RaceSystem;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class RaceFinishedController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDelayedOpen_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RaceFinishedController _003C_003E4__this;

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
		public _003CDelayedOpen_003Ed__7(int _003C_003E1__state)
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
	private StringCompareCondition isHome;

	[SerializeField]
	private RaceFinishedPanelController finishedPanel;

	[SerializeField]
	private Navigatable panel;

	[SerializeField]
	private RaceProgressPanelController progressPanel;

	[SerializeField]
	private RaceSystem raceSystem;

	private Coroutine coroutine;

	public void RaceFinished()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayedOpen_003Ed__7))]
	private IEnumerator DelayedOpen()
	{
		return null;
	}

	private void OpenOngoingPanel()
	{
	}
}
