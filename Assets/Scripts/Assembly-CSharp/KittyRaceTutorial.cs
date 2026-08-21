using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class KittyRaceTutorial : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStartOpenObject_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public KittyRaceTutorial _003C_003E4__this;

		private float _003Ctimer_003E5__2;

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
		public _003CStartOpenObject_003Ed__11(int _003C_003E1__state)
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
	private Button panelButton;

	[SerializeField]
	private List<GameObject> tutorialObject;

	[SerializeField]
	private GameObject tutorialPanel;

	[SerializeField]
	private float delay;

	private Coroutine showCoroutine;

	private int currentIndex;

	private bool isSkipping;

	private bool isRunning;

	public void OpenPanel()
	{
	}

	public void ClosePanel()
	{
	}

	private void OnClickPanelButton()
	{
	}

	[IteratorStateMachine(typeof(_003CStartOpenObject_003Ed__11))]
	private IEnumerator StartOpenObject()
	{
		return null;
	}

	private void OpenObject(GameObject o)
	{
	}

	private void ResetPanel()
	{
	}
}
