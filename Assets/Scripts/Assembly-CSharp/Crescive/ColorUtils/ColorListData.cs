using System.Collections.Generic;
using UnityEngine;

namespace Crescive.ColorUtils
{
	[CreateAssetMenu(fileName = "ColorListData", menuName = "GameData/ListData/ColorListData", order = 1)]
	public class ColorListData : ScriptableObject
	{
		[SerializeField]
		private List<Color> colors;

		public List<Color> Colors => null;

		public Color GetColor(int index)
		{
			return default(Color);
		}

		public Color GetColorByOrder(int order)
		{
			return default(Color);
		}

		public Color GetRandomColor()
		{
			return default(Color);
		}
	}
}
