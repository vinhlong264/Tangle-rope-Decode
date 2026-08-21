using System.Collections.Generic;
using PersistentSO;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Collection
{
	[CreateAssetMenu(fileName = "CollectionItemSystemsChannel", menuName = "Crescive/Collection/CollectionItemSystemsChannel")]
	public class CollectionItemSystemsChannel : ScriptableObject
	{
		[SerializeField]
		private List<CollectionItemSystem> collectionItemSystems;

		[SerializeField]
		private PersistentStringListVariable unlockedCollectionItems;

		public UnityEvent<string> OnCollectionItemUnlocked;

		public void TryEquipCollectionItem(string itemId)
		{
		}

		public BaseCollectionItemGameData GetItemGameDataWithId(string itemId)
		{
			return null;
		}

		public List<string> GetAllItemIds()
		{
			return null;
		}

		public List<string> GetAllItemIdsExceptUnlocked()
		{
			return null;
		}

		public List<string> GetAllItemIdsExceptUnlockedAndExceptedSystems(List<CollectionItemSystem> exceptedSystems)
		{
			return null;
		}

		public void UnlockCollectionItem(string itemId)
		{
		}

		public bool IsItemUnlocked(string itemId)
		{
			return false;
		}
	}
}
