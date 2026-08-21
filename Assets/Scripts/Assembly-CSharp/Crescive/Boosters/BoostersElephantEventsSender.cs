using System.Collections.Generic;
using Crescive.ResourceSystem;
using UnityEngine;

namespace Crescive.Boosters
{
	public class BoostersElephantEventsSender : MonoBehaviour
	{
		[SerializeField]
		private CresciveEventSender eventSender;

		[SerializeField]
		private BoosterSystem boosterSystem;

		[SerializeField]
		private AnalyticsEventParamHelper analyticsEventParamHelper;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SendBoosterPerformedEvent(BoosterChannel boosterChannel)
		{
		}

		private void SendBoosterPurchasedWithResourceEvent(BoosterChannel boosterChannel, ResourceValueEventArgs args)
		{
		}

		private Dictionary<string, object> GetBoosterParameters(BoosterChannel boosterChannel)
		{
			return null;
		}
	}
}
