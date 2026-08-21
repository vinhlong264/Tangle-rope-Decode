using System.Collections.Generic;
using Crescive.HelperTypes;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.SelectableItems
{
	public class SelectableItem : MonoBehaviour
	{
		[SerializeField]
		private StringVariableReference id;

		[SerializeField]
		private bool locked;

		[SerializeField]
		private bool clickWhenLocked;

		[SerializeField]
		private bool selectWhenLocked;

		[SerializeField]
		private List<GameObject> focusedObjects;

		[SerializeField]
		private List<GameObject> unfocusedObjects;

		[SerializeField]
		private List<GameObject> selectedObjects;

		[SerializeField]
		private List<GameObject> deselectedObjects;

		[SerializeField]
		private List<GameObject> lockedObjects;

		[SerializeField]
		private List<GameObject> unlockedObjects;

		[SerializeField]
		private bool isFocused;

		[SerializeField]
		private bool isSelected;

		public UnityEvent<SelectableItem> OnClick;

		public UnityEvent<SelectableItem> OnFocused;

		public UnityEvent<SelectableItem> OnUnfocused;

		public UnityEvent<SelectableItem> OnSelected;

		public UnityEvent<SelectableItem> OnDeselected;

		public UnityEvent<SelectableItem> OnLocked;

		public UnityEvent<SelectableItem> OnUnlocked;

		public UnityEvent<SelectableItem> OnUnlockedFirstTime;

		public string Id => null;

		public bool IsFocused => false;

		public bool IsSelected => false;

		public bool IsLocked => false;

		public bool CanSelect => false;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void UpdateUI()
		{
		}

		private void RaiseLockedEvent()
		{
		}

		public void OnClickCallback()
		{
		}

		public void SetFocusedState(bool state)
		{
		}

		public void SetSelectedState(bool state)
		{
		}

		public void SetLockState(bool state)
		{
		}

		public void UnlockFirstTime()
		{
		}
	}
}
