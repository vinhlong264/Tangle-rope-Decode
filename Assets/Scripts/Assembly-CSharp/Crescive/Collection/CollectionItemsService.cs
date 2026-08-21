using System.Collections.Generic;
using Crescive.DataService;
using UnityEngine;

namespace Crescive.Collection
{
	[CreateAssetMenu(fileName = "CollectionItemsService", menuName = "Crescive/Collection/CollectionItemsService")]
	public class CollectionItemsService : DataReadService<CollectionItemsData>
	{
		[SerializeField]
		private List<BaseCollectionItemGameData> itemsGameData;

		public CollectionItemData FirstItem => null;

		public BaseCollectionItemGameData FirstItemGameData => null;

		protected override CollectionItemsData GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(CollectionItemsData plainData)
		{
			return false;
		}

		public CollectionItemData GetItemDataWithId(string itemId)
		{
			return null;
		}

		public BaseCollectionItemGameData GetItemGameDataWithId(string itemId)
		{
			return null;
		}

		public BaseCollectionItemGameData GetItemGameDataForItemData(CollectionItemData collectionItemData)
		{
			return null;
		}

		public T GetItemGameDataWithId<T>(string itemId) where T : ScriptableObject
		{
			return null;
		}

		public T GetItemGameDataForItemData<T>(CollectionItemData collectionItemData) where T : ScriptableObject
		{
			return null;
		}

		public List<string> GetAllItemIds()
		{
			return null;
		}
	}
}
