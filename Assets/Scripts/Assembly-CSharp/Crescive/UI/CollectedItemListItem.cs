using Crescive.Rewards;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.UI
{
	public class CollectedItemListItem : MonoBehaviour
	{
		[SerializeField]
		private Image itemIconImage;

		[SerializeField]
		private TextMeshProUGUI itemInfoText;

		public void SetData(BaseDailyRewardData item)
		{
		}
	}
}
