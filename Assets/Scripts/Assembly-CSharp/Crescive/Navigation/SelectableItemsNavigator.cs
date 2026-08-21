using System.Collections.Generic;
using Crescive.SelectableItems;
using UnityEngine;

namespace Crescive.Navigation
{
	public class SelectableItemsNavigator : MonoBehaviour
	{
		[SerializeField]
		private NavigationStack navigationStack;

		[SerializeField]
		private SelectableItemsController selectableItemsController;

		[SerializeField]
		private List<SelectableItemNavigation> selectableItemNavigations;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnItemSelectedCallback(SelectableItem selectableItem)
		{
		}

		private void OnNavigatableShowCallback(Navigatable navigatable)
		{
		}
	}
}
