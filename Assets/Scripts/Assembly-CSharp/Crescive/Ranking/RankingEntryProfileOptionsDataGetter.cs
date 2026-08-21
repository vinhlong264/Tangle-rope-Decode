using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Ranking
{
	public class RankingEntryProfileOptionsDataGetter : MonoBehaviour
	{
		[SerializeField]
		private RankingEntryProfileOptionsData data;

		public UnityEvent<Sprite> OnGetIcon;

		public UnityEvent<Color> OnGetIconColor;

		public UnityEvent<Color> OnGetIconColorDarker;

		public UnityEvent<Color> OnGetIconColorLighter;

		public void GetIcon(int id)
		{
		}

		public void GetIconColor(int id)
		{
		}
	}
}
