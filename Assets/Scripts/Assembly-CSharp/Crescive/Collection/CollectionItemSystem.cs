using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Collection
{
	[CreateAssetMenu(fileName = "CollectionItemSystem", menuName = "Crescive/Collection/CollectionItemSystem")]
	public class CollectionItemSystem : ScriptableObject
	{
		[SerializeField]
		private CollectionItemsService itemsService;

		[SerializeField]
		public PersistentStringVariable selectedCollectionItem;

		[SerializeField]
		private StringVariable previewCollectionItem;

		[SerializeField]
		private StringReference collectionTypeId;

		public UnityEvent<CollectionItemEquipArgs> OnItemEquipped;

		public CollectionItemsService ItemsService => null;

		public PersistentStringVariable SelectedCollectionItem => null;

		public StringVariable PreviewCollectionItem => null;

		public StringReference CollectionTypeId => null;

		public bool TryEquipCollectionItem(string itemId)
		{
			return false;
		}
	}
}
