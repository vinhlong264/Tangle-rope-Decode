using UnityEngine;
using UnityEngine.Events;

namespace Crescive.SelectableItems
{
	public class SelectableItemsControllerListener : MonoBehaviour
	{
		[SerializeField]
		private SelectableItemsController selectableItemsController;

		public UnityEvent<SelectableItem> OnItemSelected;

		public UnityEvent<int> OnItemSelectedIndex;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnItemSelectedCallback(SelectableItem item)
		{
		}

		private void OnItemSelectedIndexCallback(int index)
		{
		}
	}
}
