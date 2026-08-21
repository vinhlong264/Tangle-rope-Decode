using System.Collections.Generic;
using Crescive.IAP;
using UnityAtoms;
using UnityEngine;

namespace Crescive.Analytics
{
	public class AdjustFirstTimePaymentEventIntegration : MonoBehaviour
	{
		[SerializeField]
		private PersistentUserPayments userPayments;

		[SerializeField]
		private List<AtomCondition> conditions;

		[SerializeField]
		private string token;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnPaymentChanged(UserPaymentData userPaymentData)
		{
		}
	}
}
