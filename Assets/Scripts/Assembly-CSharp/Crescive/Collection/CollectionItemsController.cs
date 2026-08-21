using System.Collections.Generic;
using Crescive.SelectableItems;
using PersistentSO;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace Crescive.Collection
{
	[DefaultExecutionOrder(1)]
	public class CollectionItemsController : MonoBehaviour
	{
		[SerializeField]
		[Header("References")]
		private SelectableItemsController selectableItemsController;

		[FormerlySerializedAs("unlockedShopItems")]
		[SerializeField]
		private PersistentStringListVariable unlockedCollectionItems;

		[SerializeField]
		private List<CollectionItemsSetup> setups;

		[Header("Override References")]
		[FormerlySerializedAs("shopItemSystem")]
		[SerializeField]
		private CollectionItemSystem collectionItemSystem;

		[SerializeField]
		private CollectionItemsControllerEvents events;

		[Header("Settings")]
		[SerializeField]
		private bool initializeOnAwake;

		[SerializeField]
		private bool initializeOnEnable;

		[SerializeField]
		private bool initializeOnStart;

		[Header("Events")]
		public UnityEvent<CollectionItem> OnFocusedCollectionItem;

		public UnityEvent<CollectionItem> OnSelectedCollectionItem;

		public UnityEvent<CollectionItem> OnUnlockedCollectionItem;

		public UnityEvent<CollectionItem> OnPurchasedCollectionItem;

		[SerializeField]
		[Header("Is Background")]
		private bool isBackground;

		private bool didInitialize;

		private string PreviewItemId => null;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Initialize()
		{
		}

		private CollectionItem GetCollectionItem(string collectionItemId)
		{
			return null;
		}

		private void OnGetItemsCallback(CollectionItemsData _)
		{
		}

		private void SubscribeToCollectionItemEvents(CollectionItem collectionItem)
		{
		}

		private void OnCollectionItemFocused(SelectableItem selectableItem)
		{
		}

		private void OnCollectionItemSelected(SelectableItem selectableItem)
		{
		}

		private void OnCollectionItemUnlocked(SelectableItem selectableItem)
		{
		}

		private void OnCollectionItemPurchaseCompleted(string collectionItemId)
		{
		}

		private void OnSelectedCollectionItemChanged(string collectionItemId)
		{
		}

		public void SetDidInitialize(bool value)
		{
		}
	}
}
