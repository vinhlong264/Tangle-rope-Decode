using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.TwistedTangle.SpecialEditor.UI
{
	public class DropdownOption : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text tmpText;

		[SerializeField]
		private Button button;

		private CustomSearchableDropdown dropdown;

		private string optionText;

		private int optionIndex;

		public string OptionText => null;

		public int OptionIndex => 0;

		private void OnDisable()
		{
		}

		public void GetInitialized(CustomSearchableDropdown dropdown, string optionText, int optionIndex)
		{
		}

		private void SelectOption()
		{
		}
	}
}
