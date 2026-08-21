using UnityEngine;
using UnityEngine.Events;

namespace Crescive.ColorUtils
{
	public class ColorListSelectorComponent : MonoBehaviour
	{
		[SerializeField]
		private ColorListData data;

		private Color lastSelectedColor;

		public UnityEvent<Color> OnColorSelected;

		private void TriggerOnColorSelected(Color selectedColor)
		{
		}

		public void TriggerEventsWithLastSelectedColor()
		{
		}

		public void SelectColor(Color color)
		{
		}

		public void SelectColor(int index)
		{
		}

		public void SelectColorByOrder(int order)
		{
		}

		public void SelectRandomColor()
		{
		}
	}
}
