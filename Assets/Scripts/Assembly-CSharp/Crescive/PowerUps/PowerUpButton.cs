using Crescive.IAP.UI;
using Crescive.ResourceSystem.UI;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.PowerUps
{
	[DefaultExecutionOrder(1)]
	public class PowerUpButton : MonoBehaviour
	{
		[SerializeField]
		private PowerUpChannel powerUpChannel;

		[Space]
		[SerializeField]
		private PowerUpSystem powerUpSystem;

		[Space]
		[SerializeField]
		private BoolVariableInstancer hasResource;

		[SerializeField]
		private BoolVariableInstancer isUnlocked;

		[SerializeField]
		private BoolVariableInstancer isFree;

		[SerializeField]
		private BoolVariableInstancer isSelected;

		[SerializeField]
		private BoolVariableInstancer isInfinite;

		[SerializeField]
		private BoolVariableInstancer isClickable;

		[SerializeField]
		private BoolVariableInstancer areIndicatorsActive;

		[Space]
		[SerializeField]
		private IntVariableInstancer minLevel;

		[Space]
		[SerializeField]
		private Image iconImage;

		[SerializeField]
		private Canvas sortOverrideCanvas;

		[SerializeField]
		private ResourceViewController resourceViewController;

		[SerializeField]
		private TemporaryProductStatusPanel temporaryProductStatusPanel;

		private bool forceSortOverrideCanvas;

		private bool forceUnlocked;

		private bool forceUnselected;

		private bool forceIndicatorsInactive;

		public PowerUpChannel PowerUpChannel => null;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SyncDataToComponents()
		{
		}

		private void OnAnyPowerUpTutorialActivated(PowerUpChannel _)
		{
		}

		private void OnTemporaryProductStatusPanelActiveCallback()
		{
		}

		private void OnTemporaryProductStatusPanelExpiredCallback()
		{
		}

		private void OnPowerUpAmountChangedCallback(float value)
		{
		}

		private void OnPowerUpStartedCallback(PowerUpChannel _)
		{
		}

		private void OnPowerUpCanceledOrFinishedCallback(PowerUpChannel _)
		{
		}

		private void SetupComponentsForCurrentPowerUp()
		{
		}

		private void SubscribeToPowerUpChannel()
		{
		}

		private void UnsubscribeFromPowerUpChannel()
		{
		}

		public void Initialize(PowerUpChannel powerUp)
		{
		}

		public void OnClickButton()
		{
		}

		public void SetForceSortOverrideCanvas(bool value)
		{
		}

		public void SetForceUnlocked(bool value)
		{
		}

		public void SetForceUnselected(bool value)
		{
		}

		public void SetForceIndicatorsInactive(bool value)
		{
		}

		public void ResetTemporaryButtonStates()
		{
		}
	}
}
