using Crescive.ResourceSystem;
using UnityEngine;

namespace Crescive.PowerUps
{
	public class PowerUpSystemController : MonoBehaviour
	{
		[SerializeField]
		private PowerUpSystem powerUpSystem;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnPowerUpSelectedCallback(PowerUpChannel powerUpChannel)
		{
		}

		private void OnPowerUpUnselectedCallback(PowerUpChannel powerUpChannel)
		{
		}

		private void OnPowerUpStartedCallback(PowerUpChannel powerUpChannel)
		{
		}

		private void OnPowerUpCanceledCallback(PowerUpChannel powerUpChannel)
		{
		}

		private void OnPowerUpPerformedCallback(PowerUpChannel powerUpChannel)
		{
		}

		private void OnPowerUpFinishedCallback(PowerUpChannel powerUpChannel)
		{
		}

		private void OnPowerUpCanceledOrFinishedCallback(PowerUpChannel powerUpChannel)
		{
		}

		private void OnResourceNotEnoughCallback(PowerUpChannel powerUpChannel)
		{
		}

		private void OnResourceIsInfiniteCallback(PowerUpChannel powerUpChannel)
		{
		}

		private void OnTutorialActivatedCallback(PowerUpChannel powerUpChannel)
		{
		}

		private void OnMustUseOnceCallback(PowerUpChannel powerUpChannel)
		{
		}

		private void OnPowerUpPurchasedWithResourceCallback(PowerUpChannel arg0, ResourceValueEventArgs arg1)
		{
		}
	}
}
