using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.SelectableItems
{
	public class SelectableItemsController : MonoBehaviour
	{
		[SerializeField]
		private bool autoSetup;

		[SerializeField]
		private bool hasDefaultSelected;

		[SerializeField]
		private int defaultSelectedIndex;

		[SerializeField]
		private List<SelectableItem> items;

		private SelectableItem selectedItem;

		private SelectableItem focusedItem;

		public UnityEvent<SelectableItem> OnItemSelected;

		public UnityEvent<int> OnItemSelectedIndex;

		public UnityEvent<string> OnItemSelectedId;

		public UnityEvent<SelectableItem> OnItemFocused;

		public UnityEvent<int> OnItemFocusedIndex;

		public UnityEvent<string> OnItemFocusedId;

		public List<SelectableItem> Items => null;

		private void Awake()
		{
		}

		private void GetItemsFromChildren()
		{
		}

		private List<SelectableItem> GetItemsListFromChildren()
		{
			return null;
		}

		private void Setup()
		{
		}

		private void SubscribeToItems()
		{
		}

		private void OnClickItem(SelectableItem item)
		{
		}

		public void Setup(List<SelectableItem> itemsList)
		{
		}

		public void FocusItem(SelectableItem item)
		{
		}

		public void SelectItem(SelectableItem item)
		{
		}

		public void SelectItem(int index)
		{
		}

		public void FocusAndSelectItem(SelectableItem item)
		{
		}
	}
}
