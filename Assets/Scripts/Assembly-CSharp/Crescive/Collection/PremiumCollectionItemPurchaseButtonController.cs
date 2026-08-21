using Crescive.IAP;
using Crescive.UI;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.UI;

namespace Crescive.Collection
{
	public class PremiumCollectionItemPurchaseButtonController : MonoBehaviour
	{
		[SerializeField]
		private CollectionItemsController collectionItemsController;

		[SerializeField]
		private CollectionItemType premiumItemType;

		[SerializeField]
		private Button button;

		[SerializeField]
		private AnimatedRaycastTarget buttonAnimatedRaycastTarget;

		[SerializeField]
		private IAPPurchaser iapPurchaser;

		[Space]
		[SerializeField]
		private StringVariableInstancer priceVar;

		[SerializeField]
		private StringVariableInstancer currencyVar;

		[SerializeField]
		private PremiumCollectionItem currentCollectionItem;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SyncStateToInstancers()
		{
		}

		private void TriggerPurchaseCompleted()
		{
		}

		private void OnPurchaseCompleted(Product _)
		{
		}

		private void OnPurchaseCompletedWithoutVerification(Product _)
		{
		}

		public void SetCurrentCollectionItem(CollectionItem collectionItem)
		{
		}
	}
}
