using Crescive.HelperTypes;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.PeriodicOffer
{
	public class PeriodicOfferIdBehaviour : MonoBehaviour
	{
		[SerializeField]
		private string id;

		[SerializeField]
		private AutoTriggerMethod autoTriggerMethod;

		public UnityEvent<string> OnIdChanged;

		public UnityEvent<string> OnAfterIdChanged;

		public string Id => null;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void TriggerIdChanged(string value)
		{
		}

		public void SetId(string value)
		{
		}
	}
}
