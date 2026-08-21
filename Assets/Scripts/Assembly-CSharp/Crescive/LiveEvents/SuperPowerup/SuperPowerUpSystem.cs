using Crescive.PowerUps;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.LiveEvents.SuperPowerup
{
	[CreateAssetMenu(fileName = "SuperPowerUpEvents", menuName = "Crescive/Analytics/Events/SuperPowerUpEvents")]
	public class SuperPowerUpSystem : ScriptableObject
	{
		[Header("Events")]
		public UnityEvent OnSuperPowerUpActivated;

		public UnityEvent OnSuperPowerUpDeactivated;

		public UnityEvent<string> OnSuperPowerUpUsed;

		[SerializeField]
		private PowerUpSystem powerUpSystem;

		[SerializeField]
		private PersistentConsecutiveWinSaveData persistentConsecutiveWinSaveData;

		[SerializeField]
		private SuperPowerupDataService superPowerupDataService;

		public PersistentConsecutiveWinSaveData PersistentConsecutiveWinSaveData => null;

		public void LoseSuperPowerUps()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void TriggerSuperPowerUpActivated()
		{
		}

		public void TriggerSuperPowerUpDeactivated()
		{
		}

		private void HandlePowerUpPerformed(PowerUpChannel powerUpChannel)
		{
		}

		public bool IsSuperPowerUp(string powerUpId)
		{
			return false;
		}
	}
}
