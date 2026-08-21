using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Offer
{
	public abstract class BaseOfferEventsTriggerBehaviourSetup : MonoBehaviour
	{
		public UnityEvent OnSetupDone;

		public void Setup()
		{
		}

		protected abstract void SetupInternal();
	}
}
