using Crescive.SelectableItems;
using UnityEngine;

namespace Crescive.Navigation
{
	[DefaultExecutionOrder(-100000)]
	public class NavigationStackSelectableItemsSync : MonoBehaviour
	{
		[SerializeField]
		private NavigationStack navigationStack;

		[SerializeField]
		private SelectableItemsController selectableItemsController;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnShowCallback(Navigatable navigatable)
		{
		}

		private void OnItemSelectedIndexCallback(int index)
		{
		}
	}
}
