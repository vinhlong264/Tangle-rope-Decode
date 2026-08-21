using UnityEngine;
using UnityEngine.Events;

namespace Crescive.PowerUps
{
	public class PowerUpDataEvents : MonoBehaviour
	{
		public UnityEvent<string> OnPowerUpName;

		public void TriggerEventsForPowerUp(PowerUpChannel powerUpChannel)
		{
		}
	}
}
