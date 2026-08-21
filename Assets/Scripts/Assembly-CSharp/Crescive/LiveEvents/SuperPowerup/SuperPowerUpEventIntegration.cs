using UnityEngine;
using UnityEngine.Serialization;

namespace Crescive.LiveEvents.SuperPowerup
{
	public class SuperPowerUpEventIntegration : MonoBehaviour
	{
		[SerializeField]
		[FormerlySerializedAs("superPowerUpEvents")]
		private SuperPowerUpSystem superPowerUpSystem;

		[SerializeField]
		private PersistentConsecutiveWinSaveData persistentConsecutiveWinSaveData;

		[SerializeField]
		private CresciveEventSender cresciveEventSender;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleSuperPowerUpActivated()
		{
		}

		private void SendSuperPowerUpActivatedEvent()
		{
		}

		private void SendSuperPowerUpUsedEvent(string powerUpId)
		{
		}

		private void SendSuperPowerUpDeactivatedEvent()
		{
		}
	}
}
