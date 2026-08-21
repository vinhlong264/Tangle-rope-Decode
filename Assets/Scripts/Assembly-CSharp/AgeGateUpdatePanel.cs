using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PersistentSO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AgeGateUpdatePanel : AgeBaseGatePanel
{
	[CompilerGenerated]
	private sealed class _003CCountdown_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public long unlockAt;

		public AgeGateUpdatePanel _003C_003E4__this;

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
		public _003CCountdown_003Ed__11(int _003C_003E1__state)
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
	private Button goToSelectionButton;

	[SerializeField]
	private TMP_Text remainingTime;

	private Coroutine _countdownCo;

	private const long LockSeconds = 86400L;

	[SerializeField]
	private TMP_Text userIdfa;

	public void OpenPrivacySettings()
	{
	}

	private void OnDisable()
	{
	}

	public void Close()
	{
	}

	public void Open(PersistentIntVariable setDate, Action onClickedGoSelectionButton)
	{
	}

	private void RestartCountdown(long unlockAt)
	{
	}

	private void StopCountdown()
	{
	}

	[IteratorStateMachine(typeof(_003CCountdown_003Ed__11))]
	private IEnumerator Countdown(long unlockAt)
	{
		return null;
	}

	private void SetButtonVisible(bool visible)
	{
	}

	private static string FormatHM(long seconds)
	{
		return null;
	}
}
