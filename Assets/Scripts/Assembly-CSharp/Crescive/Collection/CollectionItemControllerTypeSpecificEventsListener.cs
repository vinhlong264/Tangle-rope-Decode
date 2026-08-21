using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace Crescive.Collection
{
	public class CollectionItemControllerTypeSpecificEventsListener : MonoBehaviour
	{
		[FormerlySerializedAs("shopItemsController")]
		[SerializeField]
		private CollectionItemsController collectionItemsController;

		[SerializeField]
		[FormerlySerializedAs("shopItemType")]
		private CollectionItemType collectionItemType;

		public UnityEvent<CollectionItem> OnFocusedCollectionItem;

		public UnityEvent<CollectionItem> OnSelectedCollectionItem;

		public UnityEvent<CollectionItem> OnUnlockedCollectionItem;

		public UnityEvent<CollectionItem> OnPurchasedCollectionItem;

		public UnityEvent<string> OnFocusedCollectionItemId;

		public UnityEvent<string> OnSelectedCollectionItemId;

		public UnityEvent<string> OnUnlockedCollectionItemId;

		public UnityEvent<string> OnPurchasedCollectionItemId;

		public UnityEvent<CollectionItem> OnFocusedCollectionItemNotMatch;

		public UnityEvent<CollectionItem> OnSelectedCollectionItemNotMatch;

		public UnityEvent<CollectionItem> OnUnlockedCollectionItemNotMatch;

		public UnityEvent<CollectionItem> OnPurchasedCollectionItemNotMatch;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnFocusedCollectionItemCallback(CollectionItem collectionItem)
		{
		}

		private void OnSelectedCollectionItemCallback(CollectionItem collectionItem)
		{
		}

		private void OnUnlockedCollectionItemCallback(CollectionItem collectionItem)
		{
		}

		private void OnPurchasedCollectionItemCallback(CollectionItem collectionItem)
		{
		}
	}
}
