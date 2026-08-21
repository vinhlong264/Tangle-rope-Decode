using System.Collections.Generic;
using Crescive.HelperTypes;
using Crescive.ResourceSystem;
using CresciveCore;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.PowerUps
{
	[CreateAssetMenu(fileName = "Power Up Channel", menuName = "Crescive/Power Ups/Core/Power Up Channel")]
	public class PowerUpChannel : ScriptableObject
	{
		[SerializeField]
		private PowerUpState currentState;

		[SerializeField]
		private LevelSystem levelSystem;

		[Space]
		[SerializeField]
		private ResourceChannel resourceChannel;

		[SerializeField]
		private PowerUpSettingsDataService settings;

		[SerializeField]
		private PowerUpUIData uiData;

		[SerializeField]
		private PersistentPowerUpData persistentData;

		[Space]
		[SerializeField]
		private List<BoolVariableReference> powerUpAvailableConditions;

		public UnityEvent<PowerUpChannel> OnSelected;

		public UnityEvent<PowerUpChannel> OnUnselected;

		public UnityEvent<PowerUpChannel> OnStarted;

		public UnityEvent<PowerUpChannel> OnCanceled;

		public UnityEvent<PowerUpChannel> OnPerformed;

		public UnityEvent<PowerUpChannel> OnFinished;

		public UnityEvent<PowerUpChannel> OnCanceledOrFinished;

		public UnityEvent<PowerUpChannel> OnResourceNotEnough;

		public UnityEvent<PowerUpChannel> OnResourceIsInfinite;

		public UnityEvent<PowerUpChannel> OnTutorialActivated;

		public UnityEvent<PowerUpChannel> OnMustUseOnce;

		public UnityEvent<PowerUpChannel, ResourceValueEventArgs> OnPowerUpPurchasedWithResource;

		public string Id => null;

		public PowerUpState CurrentState => default(PowerUpState);

		public bool IsStateStarted => false;

		public bool IsStatePerformed => false;

		public bool IsStateIdle => false;

		public bool IsInUse => false;

		public bool IsRunning => false;

		public ResourceChannel Resource => null;

		public PowerUpSettingsDataService Settings => null;

		public PowerUpUIData UIData => null;

		public PersistentPowerUpData PersistentData => null;

		public bool DidClaimFirstTime => false;

		public bool DidUseOnce => false;

		public bool IsInfinite => false;

		public bool HasResource => false;

		public bool IsPowerUpAvailable => false;

		private void SetState(PowerUpState state)
		{
		}

		private void SetSelected(bool selected)
		{
		}

		public void SetDidClaimFirstTimeAndIsSelectedTrue()
		{
		}

		public void SetDidUseOnceTrue()
		{
		}

		public void TrySelectPowerUp()
		{
		}

		public void UnselectPowerUp()
		{
		}

		public void StartPowerUp(bool spendResource = true)
		{
		}

		public void TryCancelPowerUp()
		{
		}

		public void PerformPowerUp()
		{
		}

		public void FinishPowerUp()
		{
		}

		public void ResourceNotEnough()
		{
		}

		public void ResourceIsInfinite()
		{
		}

		public void TutorialActivated()
		{
		}

		public void MustUseOnce()
		{
		}

		public void PurchasePowerUp(ResourceValueEventArgs args)
		{
		}
	}
}
