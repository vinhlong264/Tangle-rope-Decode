using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Crescive.HelperTypes;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.PeriodicOffer
{
	public class PeriodicOfferListener : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CTriggerEventsWhenOfferDateReachedCoroutine_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PeriodicOfferListener _003C_003E4__this;

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
			public _003CTriggerEventsWhenOfferDateReachedCoroutine_003Ed__19(int _003C_003E1__state)
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
		private string id;

		[SerializeField]
		private PersistentPeriodicOffers persistentPeriodicOffers;

		[SerializeField]
		private AutoTriggerMethod autoTriggerMethod;

		public UnityEvent OnOfferActive;

		public UnityEvent OnOfferDeactive;

		public UnityEvent<bool> OnOfferActiveChanged;

		public UnityEvent<bool> OnOfferActiveChangedReverse;

		public UnityEvent<string> OnGetOfferDate;

		public UnityEvent<float> OnGetOfferDateRemainingSeconds;

		private Coroutine dateReachedCoroutine;

		public string Id
		{
			get
			{
				return null;
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

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnPersistentPeriodicOffersChanged(List<PeriodicOfferData> arg0)
		{
		}

		private void TriggerEventsWhenOfferDateReached()
		{
		}

		[IteratorStateMachine(typeof(_003CTriggerEventsWhenOfferDateReachedCoroutine_003Ed__19))]
		private IEnumerator TriggerEventsWhenOfferDateReachedCoroutine()
		{
			return null;
		}

		public void TriggerEvents()
		{
		}
	}
}
