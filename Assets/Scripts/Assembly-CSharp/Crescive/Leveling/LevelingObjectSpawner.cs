using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Leveling
{
	public class LevelingObjectSpawner : MonoBehaviour
	{
		[SerializeField]
		private LevelingBehaviour prefab;

		[SerializeField]
		private Transform itemsParent;

		[SerializeField]
		private bool hasScriptableDelegate;

		[SerializeField]
		private LevelingObjectSpawnerScriptableDelegate spawnerScriptableDelegate;

		public UnityEvent<int> OnItemCountChanged;

		public UnityEvent<LevelingBehaviour> OnItemAdded;

		public UnityEvent<LevelingBehaviour> OnItemRemoved;

		public UnityEvent<LevelingBehaviour> OnItemCreated;

		private List<LevelingBehaviour> items;

		public List<LevelingBehaviour> Items => null;

		private void Awake()
		{
		}

		private void Setup()
		{
		}

		private void ItemCountChanged()
		{
		}

		private LevelingBehaviour CreateItem(int level = 1)
		{
			return null;
		}

		public void AddItem(LevelingBehaviour item)
		{
		}

		public LevelingBehaviour AddItem(int level)
		{
			return null;
		}

		public void AddItems(List<LevelingBehaviour> items)
		{
		}

		public void AddItems(int count)
		{
		}

		public void AddItems(List<int> levels)
		{
		}

		public void RemoveItem(LevelingBehaviour item)
		{
		}

		public void RemoveAllItems()
		{
		}

		public void RemoveAllItemsAndDestroy()
		{
		}

		public void AddItem()
		{
		}

		public void RemoveFirstItem()
		{
		}

		public void RemoveLastItem()
		{
		}

		public void RemoveItemsFromLast(int count = 1)
		{
		}

		public void RemoveItemsFromFirst(int count = 1)
		{
		}

		public void RemoveItems(List<LevelingBehaviour> itemsToRemove)
		{
		}

		public void RemoveItemAndDestroy()
		{
		}

		public void RemoveItemAndDestroy(LevelingBehaviour item)
		{
		}

		public void RemoveItemsAndDestroy(int count = 1)
		{
		}
	}
}
