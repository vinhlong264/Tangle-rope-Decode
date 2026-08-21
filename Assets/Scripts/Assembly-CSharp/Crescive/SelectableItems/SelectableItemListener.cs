using UnityEngine;
using UnityEngine.Events;

namespace Crescive.SelectableItems
{
	public class SelectableItemListener : MonoBehaviour
	{
		[SerializeField]
		private SelectableItem item;

		public UnityEvent<SelectableItem> OnClick;

		public UnityEvent<SelectableItem> OnFocused;

		public UnityEvent<SelectableItem> OnUnfocused;

		public UnityEvent<SelectableItem> OnSelected;

		public UnityEvent<SelectableItem> OnDeselected;

		public UnityEvent<SelectableItem> OnLocked;

		public UnityEvent<SelectableItem> OnUnlocked;

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		private void OnClickCallback(SelectableItem selectableItem)
		{
		}

		private void OnFocusedCallback(SelectableItem selectableItem)
		{
		}

		private void OnUnfocusedCallback(SelectableItem selectableItem)
		{
		}

		private void OnSelectedCallback(SelectableItem selectableItem)
		{
		}

		private void OnDeselectedCallback(SelectableItem selectableItem)
		{
		}

		private void OnLockedCallback(SelectableItem selectableItem)
		{
		}

		private void OnUnlockedCallback(SelectableItem selectableItem)
		{
		}

		private void RaiseEventsIfNecessary()
		{
		}
	}
}
