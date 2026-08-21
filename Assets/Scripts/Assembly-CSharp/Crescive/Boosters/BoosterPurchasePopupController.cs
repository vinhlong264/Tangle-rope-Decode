using Crescive.Navigation;
using Crescive.PopUps;
using Crescive.ResourceSystem;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.Boosters
{
	public class BoosterPurchasePopupController : MonoBehaviour
	{
		[SerializeField]
		private BoosterChannel boosterChannel;

		[Space]
		[SerializeField]
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

		private void OnResourceNotEnoughCallback(BoosterChannel _)
		{
		}

		private void OnResourceIncreasedCallback(ResourceValueEventArgs args)
		{
		}

		private void SubscribeToBoosterChannel()
		{
		}

		private void UnsubscribeFromBoosterChannel()
		{
		}

		public void OnApproved()
		{
		}

		public void OnApprovedWithCount(int count)
		{
		}
	}
}
