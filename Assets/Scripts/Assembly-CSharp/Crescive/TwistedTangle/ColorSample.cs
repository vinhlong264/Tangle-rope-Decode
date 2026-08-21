using System;
using Crescive.ColorUtils;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.TwistedTangle
{
	public class ColorSample : MonoBehaviour
	{
		[SerializeField]
		private Image sampleImage;

		[SerializeField]
		private Button AddButton;

		[SerializeField]
		private Button RemoveButton;

		[SerializeField]
		private Button OpenPaletteButton;

		[SerializeField]
		private ColorPlatePicker colorPalettePrefab;

		[SerializeField]
		private ColorListData defaultColorListData;

		private int defaultColorIndex;

		public Action<Color, int> OnColorChanged;

		private int _index;

		public void InitColor(Color color, int index)
		{
		}

		public void SetColor(Color color)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnAddButtonClicked()
		{
		}

		private void OnRemoveButtonClicked()
		{
		}

		public void Open()
		{
		}

		private void OnColorSelected(Color selectedColor)
		{
		}
	}
}
