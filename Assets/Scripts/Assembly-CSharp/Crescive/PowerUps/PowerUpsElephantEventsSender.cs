using System.Collections.Generic;
using Crescive.LiveEvents.SuperPowerup;
using Crescive.ResourceSystem;
using UnityEngine;

namespace Crescive.PowerUps
{
	public class PowerUpsElephantEventsSender : MonoBehaviour
	{
		[SerializeField]
		private CresciveEventSender eventSender;

		[SerializeField]
		private PowerUpSystem powerUpSystem;

		[SerializeField]
		private SuperPowerUpSystem superPowerUpSystem;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SendPowerUpPerformedEvent(PowerUpChannel powerUpChannel)
		{
		}

		private void SendPowerUpPurchasedWithResourceEvent(PowerUpChannel powerUpChannel, ResourceValueEventArgs args)
		{
		}

		private Dictionary<string, object> GetPowerUpParameters(PowerUpChannel powerUpChannel)
		{
			return null;
		}
	}
}
