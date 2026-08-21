using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Ranking
{
	[CreateAssetMenu(menuName = "Crescive/Ranking/Options/Ranking Entry Profile Options Data", fileName = "RankingEntryProfileOptionsData")]
	public class RankingEntryProfileOptionsData : ScriptableObject
	{
		[SerializeField]
		public List<Sprite> icons;

		[SerializeField]
		public List<Color> iconColors;

		public Sprite GetIcon(int id)
		{
			return null;
		}

		public Color GetIconColor(int id)
		{
			return default(Color);
		}

		public Color GetColorDarker(Color color)
		{
			return default(Color);
		}

		public Color GetColorLighter(Color color)
		{
			return default(Color);
		}
	}
}
