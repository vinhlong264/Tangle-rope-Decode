using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Collection
{
	[CreateAssetMenu(fileName = "CollectionItemsControllerEvents", menuName = "Crescive/Collection/CollectionItemsControllerEvents")]
	public class CollectionItemsControllerEvents : ScriptableObject
	{
		public UnityEvent<CollectionItem> OnFocusedCollectionItem;

		public UnityEvent<CollectionItem> OnSelectedCollectionItem;

		public UnityEvent<CollectionItem> OnUnlockedCollectionItem;

		public UnityEvent<CollectionItem> OnPurchasedCollectionItem;

		public void TriggerOnFocusedCollectionItem(CollectionItem collectionItem)
		{
		}

		public void TriggerOnSelectedCollectionItem(CollectionItem collectionItem)
		{
		}

		public void TriggerOnUnlockedCollectionItem(CollectionItem collectionItem)
		{
		}

		public void TriggerOnPurchasedCollectionItem(CollectionItem collectionItem)
		{
		}
	}
}
