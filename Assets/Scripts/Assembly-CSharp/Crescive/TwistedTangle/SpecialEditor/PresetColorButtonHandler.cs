using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.TwistedTangle.SpecialEditor
{
	public class PresetColorButtonHandler : MonoBehaviour
	{
		[SerializeField]
		private Image colorImage;

		[SerializeField]
		private ColorVariable selectedColor;

		[SerializeField]
		private BoolEvent OnDeleteColorSelected;

		private Color buttonColor;

		private PresetColorsHandler colorsHandler;

		private int buttonIndex;

		private bool isInDeleteMode;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void ToggleDeleteMode(bool deleteModeIsActive)
		{
		}

		private void ActivateDeleteMode()
		{
		}

		private void DeactivateDeleteMode()
		{
		}

		private void SelectColor()
		{
		}

		private void RemoveThisButton()
		{
		}

		public void InitializeButton(Color color, int buttonIndex, PresetColorsHandler colorsHandler)
		{
		}

		public void SetButtonIndex(int buttonIndex)
		{
		}

		public void ButtonAction()
		{
		}
	}
}
