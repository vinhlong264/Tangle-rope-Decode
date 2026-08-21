using System;
using System.Collections.Generic;
using Crescive.IAP;
using PersistentSO;
using UnityEngine;

namespace Crescive.Analytics
{
	public class AdjustTotalRevenueEventsIntegration : MonoBehaviour
	{
		[Serializable]
		private struct RevenueTokenData
		{
			public float Revenue;

			public string Token;
		}

		[SerializeField]
		private PersistentFloatVariable totalAdRevenue;

		[SerializeField]
		private PersistentUserPayments totalIapRevenue;

		[SerializeField]
		private PersistentFloatVariable previousEventRevenue;

		[SerializeField]
		private List<RevenueTokenData> revenueTokenData;

		[SerializeField]
		private float iapRevenueCutPercentage;

		private float TotalRevenue => 0f;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnTotalAdRevenueChanged(float newRevenue)
		{
		}

		private void OnTotalIapRevenueChanged(UserPaymentData arg0)
		{
		}

		private void TrackRevenue()
		{
		}

		private void SendRevenueEvent(RevenueTokenData data)
		{
		}
	}
}
