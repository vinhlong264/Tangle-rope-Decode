using Crescive.Navigation;
using Crescive.PopUps;
using Crescive.ResourceSystem;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.PowerUps
{
	public class PowerUpPurchasePopupController : MonoBehaviour
	{
		[SerializeField]
		private PowerUpChannel powerUpChannel;

		[SerializeField]
		[Space]
		private Navigatable navigatable;

		[SerializeField]
		private OfferPopUp offerPopUp;

		[SerializeField]
		private Transform purchasePosition;

		[Space]
		[SerializeField]
		private Image itemIconImage;

		[SerializeField]
		private StringReference itemName;

		[SerializeField]
		private StringReference itemDescription;

		[SerializeField]
		private IntReference itemPurchaseAmount;

		[SerializeField]
		private FloatReference itemCost;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SyncDataToComponents()
		{
		}

		private void OnResourceNotEnoughCallback(PowerUpChannel _)
		{
		}

		private void OnResourceIncreasedCallback(ResourceValueEventArgs args)
		{
		}

		private void SubscribeToPowerUpChannel()
		{
		}

		private void UnsubscribeFromPowerUpChannel()
		{
		}

		public void OnApproved()
		{
		}
	}
}
