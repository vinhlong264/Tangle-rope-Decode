using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle.SpecialEditor.UI
{
	public class CustomSearchableDropdown : MonoBehaviour
	{
		[SerializeField]
		private Transform content;

		[SerializeField]
		private DropdownOption dropdownOption;

		[SerializeField]
		private RectTransform scrollViewRect;

		[SerializeField]
		private int maxWidth;

		[SerializeField]
		private SelectedStringType selectedStringType;

		[SerializeField]
		private List<string> options;

		[SerializeField]
		private List<StringVariable> stringVariables;

		[SerializeField]
		private List<StringConstant> stringConstants;

		private List<string> allOptions;

		private List<GameObject> optionObjects;

		public UnityEvent onOptionSelected;

		public UnityEvent<int> onOptionIndexSelected;

		public UnityEvent<string> onOptionTextSelected;

		public UnityEvent<string> OnSubmitString;

		public UnityEvent<int> OnSubmitInt;

		public UnityEvent OnSubmit;

		public int SelectedValue { get; private set; }

		public string SelectedText { get; private set; }

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void InitializeScrollViewSize(int optionCount)
		{
		}

		private void GenerateDropdown(List<string> options)
		{
		}

		private void DestroyOptions()
		{
		}

		private void CreateOptions(List<string> options, bool shouldSort = true)
		{
		}

		public void OnSearchValueChanged(string searchQuery)
		{
		}

		public void ActivateScrollView()
		{
		}

		public void RecreateOptions(List<string> options)
		{
		}

		public void RecreateOptions(List<StringConstant> options)
		{
		}

		public void AddOptions(List<string> options)
		{
		}

		public void AddOptions(List<StringConstant> options)
		{
		}

		public void SelectOption(string optionText, int optionIndex)
		{
		}

		public void SubmitValue()
		{
		}
	}
}
