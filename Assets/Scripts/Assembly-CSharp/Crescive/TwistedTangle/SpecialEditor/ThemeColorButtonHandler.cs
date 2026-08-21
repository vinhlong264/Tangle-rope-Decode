using System.Collections.Generic;
using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.TwistedTangle.SpecialEditor
{
	public class ThemeColorButtonHandler : MonoBehaviour
	{
		[SerializeField]
		private ColorVariable selectedColor;

		[SerializeField]
		private BoolEvent OnDeleteColorSelected;

		[SerializeField]
		private Transform imageSpawnTransform;

		[SerializeField]
		private List<PersistentColor> persistentColors;

		private List<Color> buttonColor;

		private ThemeColorsHandler colorsHandler;

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

		public void InitializeButton(ColorListStruct color, int buttonIndex, ThemeColorsHandler colorsHandler)
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
