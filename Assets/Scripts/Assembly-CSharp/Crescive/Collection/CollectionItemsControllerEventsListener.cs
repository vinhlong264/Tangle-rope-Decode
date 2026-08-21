using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Collection
{
	public class CollectionItemsControllerEventsListener : MonoBehaviour
	{
		[SerializeField]
		private CollectionItemsControllerEvents events;

		public UnityEvent<CollectionItem> OnFocusedCollectionItem;

		public UnityEvent<CollectionItem> OnSelectedCollectionItem;

		public UnityEvent<CollectionItem> OnUnlockedCollectionItem;

		public UnityEvent<CollectionItem> OnPurchasedCollectionItem;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
