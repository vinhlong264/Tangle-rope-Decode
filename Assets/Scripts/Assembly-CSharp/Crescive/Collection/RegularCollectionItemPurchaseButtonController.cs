using Crescive.ResourceSystem;
using Crescive.UI;
using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.Collection
{
	public class RegularCollectionItemPurchaseButtonController : MonoBehaviour
	{
		[SerializeField]
		private CollectionItemsController collectionItemsController;

		[SerializeField]
		private CollectionItemType regularItemType;

		[SerializeField]
		private Button button;

		[SerializeField]
		private ResourceSpendBehaviour spendBehaviour;

		[SerializeField]
		private AnimatedRaycastTarget buttonAnimatedRaycastTarget;

		[SerializeField]
		private PersistentStringListVariable unlockedCollectionItemIds;

		[SerializeField]
		[Space]
		private FloatVariableInstancer costVar;

		[SerializeField]
		private CollectionItem currentCollectionItem;

		private void OnEnable()
		{
		}

		private void SyncStateToInstancers()
		{
		}

		public void SetCurrentCollectionItem(CollectionItem collectionItem)
		{
		}

		public void TryPurchase()
		{
		}

		public void OnPurchaseSuccessful()
		{
		}
	}
}
