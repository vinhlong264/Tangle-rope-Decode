using PersistentSO;
using UnityEngine;
using UnityEngine.Serialization;

namespace Crescive.Collection
{
	public abstract class CollectionItemActor<T> : BaseCollectionItemActor where T : ScriptableObject
	{
		[FormerlySerializedAs("shopItemSystem")]
		[SerializeField]
		private CollectionItemSystem collectionItemSystem;

		[FormerlySerializedAs("selectedShopItemId")]
		[SerializeField]
		private PersistentStringVariable selectedCollectionItemId;

		[SerializeField]
		protected bool isPreview;

		private string SelectedItemId => null;

		protected virtual void OnEnable()
		{
		}

		private void Start()
		{
		}

		protected virtual void OnDisable()
		{
		}

		private void OnItemSelected(string itemId)
		{
		}

		protected abstract void OnItemSelectedInternal(T itemGameData);

		private void SubscribeToCollectionItemId()
		{
		}

		private void UnsubscribeFromCollectionItemId(bool reverse = false)
		{
		}
	}
}
