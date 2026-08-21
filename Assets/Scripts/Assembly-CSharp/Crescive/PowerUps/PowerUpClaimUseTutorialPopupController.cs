using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Crescive.PopUps;
using Crescive.UI;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.PowerUps
{
	public class PowerUpClaimUseTutorialPopupController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CShowRoutine_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PowerUpClaimUseTutorialPopupController _003C_003E4__this;

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
			public _003CShowRoutine_003Ed__13(int _003C_003E1__state)
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
		private PowerUpChannel powerUpChannel;

		[SerializeField]
		[Space]
		private bool autoCheckForPushOnSetupDone;

		[Space]
		[SerializeField]
		private PowerUpSystem powerUpSystem;

		[SerializeField]
		private PowerUpButtonsControllerChannel buttonsControllerChannel;

		[SerializeField]
		private OfferPopUp offerPopUp;

		[Space]
		[SerializeField]
		private StringVariableInstancer tutorialTextKey;

		[SerializeField]
		private StringVariableInstancer powerUpNameKey;

		[Space]
		[SerializeField]
		private RectTransform tutorialFocus;

		[SerializeField]
		private UIEventTriggerDelegate eventTriggerDelegate;

		private PowerUpButton PowerUpButton => null;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		[IteratorStateMachine(typeof(_003CShowRoutine_003Ed__13))]
		private IEnumerator ShowRoutine()
		{
			return null;
		}

		public void CheckForPush()
		{
		}

		public void OnShow()
		{
		}

		public void OnHide()
		{
		}

		public void OnApproved()
		{
		}
	}
}
