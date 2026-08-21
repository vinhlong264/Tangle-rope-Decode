using Crescive.ResourceSystem.UI;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.Boosters
{
	[DefaultExecutionOrder(1)]
	public class BoosterButton : MonoBehaviour
	{
		[SerializeField]
		private BoosterChannel boosterChannel;

		[Space]
		[SerializeField]
		private BoosterSystem boosterSystem;

		[SerializeField]
		[Space]
		private BoolVariableInstancer hasResource;

		[SerializeField]
		private BoolVariableInstancer isUnlocked;

		[SerializeField]
		private BoolVariableInstancer isInUse;

		[SerializeField]
		private BoolVariableInstancer isActive;

		[SerializeField]
		private BoolVariableInstancer isClickable;

		[Space]
		[SerializeField]
		private IntVariableInstancer minLevel;

		[Space]
		[SerializeField]
		private Image iconImage;

		[SerializeField]
		private ResourceViewController resourceViewController;

		[SerializeField]
		private Canvas sortOverrideCanvas;

		private bool forceSortOverrideCanvas;

		private bool forceUnlocked;

		private bool forceUnclickable;

		public BoosterChannel BoosterChannel => null;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SyncBindings()
		{
		}

		private void OnBoosterAmountChangedCallback(float value)
		{
		}

		private void OnBoosterStartedCallback(BoosterChannel _)
		{
		}

		private void OnBoosterCanceledOrFinishedCallback(BoosterChannel _)
		{
		}

		private void OnButtonActiveConditionChangedCallback(bool _)
		{
		}

		private void SubscribeToBoosterChannel()
		{
		}

		private void UnsubscribeFromBoosterChannel()
		{
		}

		public void Initialize(BoosterChannel booster)
		{
		}

		public void TryRequestBooster()
		{
		}

		public void OnAnyBoosterRequestedCallback()
		{
		}

		public void OnAnyBoosterCanceledOrFinishedCallback()
		{
		}

		public void SetForceSortOverrideCanvas(bool value)
		{
		}

		public void SetForceUnlocked(bool value)
		{
		}

		public void SetForceUnclickable(bool value)
		{
		}

		public void ResetTemporaryButtonStates()
		{
		}
	}
}
