using System.Collections.Generic;
using Crescive.ResourceSystem;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.PowerUps
{
	public class PowerUpSystemListener : MonoBehaviour
	{
		[SerializeField]
		private PowerUpSystem powerUpSystem;

		[SerializeField]
		private List<PowerUpChannel> exceptedPowerUps;

		[SerializeField]
		private List<PowerUpChannel> includedPowerUps;

		public UnityEvent<PowerUpChannel> OnSelected;

		public UnityEvent<PowerUpChannel> OnUnselected;

		public UnityEvent<PowerUpChannel> OnStarted;

		public UnityEvent<PowerUpChannel> OnCanceled;

		public UnityEvent<PowerUpChannel> OnPerformed;

		public UnityEvent<PowerUpChannel> OnFinished;

		public UnityEvent<PowerUpChannel> OnCanceledOrFinished;

		public UnityEvent<PowerUpChannel> OnResourceNotEnough;

		public UnityEvent<PowerUpChannel> OnResourceIsInfinite;

		public UnityEvent<PowerUpChannel> OnMustUseOnce;

		public UnityEvent<PowerUpChannel> OnTutorialActivated;

		public UnityEvent<PowerUpChannel, ResourceValueEventArgs> OnPowerUpPurchasedWithResource;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private bool IsPowerUpChannelValid(PowerUpChannel powerUpChannel)
		{
			return false;
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

		private void OnPowerUpPurchasedWithResourceCallback(PowerUpChannel powerUpChannel, ResourceValueEventArgs args)
		{
		}
	}
}
