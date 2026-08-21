using System.Collections.Generic;
using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle.SpecialEditor.UI
{
	public class DropdownController : MonoBehaviour
	{
		[SerializeField]
		private TMP_Dropdown dropdown;

		[SerializeField]
		private float singleItemHeight;

		[SerializeField]
		private List<StringConstant> constantItems;

		[SerializeField]
		private SpecialRemoteConfigGetter configGetter;

		[SerializeField]
		private bool shouldGetFromRemoteConfig;

		public UnityEvent<string> OnSubmitString;

		public UnityEvent<int> OnSubmitInt;

		[SerializeField]
		private UnityEvent<string> OnValueChanged;

		[SerializeField]
		private UnityEvent OnDropdownChangedWithSearch;

		private List<StringConstant> searchedItems;

		private List<string> constantItemsStrings;

		private List<string> searchedItemsStrings;

		public int Value { get; private set; }

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void ChangeValue(int valueToPass)
		{
		}

		private void InitializeDropdown()
		{
		}

		public void SubmitValue()
		{
		}

		public void SetDropdownWithKeyword(string keyword)
		{
		}
	}
}
