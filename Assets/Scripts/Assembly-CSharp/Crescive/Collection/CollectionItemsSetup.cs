using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Collection
{
	public abstract class CollectionItemsSetup : MonoBehaviour
	{
		[SerializeField]
		private CollectionItemType collectionItemType;

		[SerializeField]
		private Transform itemsParent;

		public List<CollectionItem> GetCollectionItems(CollectionItemSystem collectionItemSystem, bool isBackground = false)
		{
			return null;
		}

		protected abstract List<CollectionItemData> GetFilteredDataList(List<CollectionItemData> itemsData);
	}
}
