using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.Ranking
{
	public class RankingEntryRewardComponent : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text rewardText;

		[SerializeField]
		private Image rewardIcon;

		public void SetData(string text, Sprite icon)
		{
		}
	}
}
