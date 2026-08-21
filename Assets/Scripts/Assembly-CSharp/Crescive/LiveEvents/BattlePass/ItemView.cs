using Coffee.UIEffects;
using Crescive.IAP;
using Crescive.Shop;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.LiveEvents.BattlePass
{
	public class ItemView : MonoBehaviour
	{
		[SerializeField]
		private Image rewardIcon;

		[SerializeField]
		private TextMeshProUGUI xAmountText;

		[SerializeField]
		private TextMeshProUGUI durationAmountText;

		[SerializeField]
		private TextMeshProUGUI coinAmountText;

		[SerializeField]
		private UIShiny shinyEffect;

		[SerializeField]
		private IAPDataService iapDataService;

		[SerializeField]
		private ShopProductsAssetData shopProductsAssetData;

		public void Setup(string productId)
		{
		}

		public static (Sprite, int?, int?, float?, bool?)? GetInfo(string productId, IAPDataService iapDataService, ShopProductsAssetData shopProductsAssetData)
		{
			return null;
		}

		public void Setup(Sprite? sprite, int? xAmount, int? amount, float? seconds, bool? isChestBundle)
		{
		}

		private string GetMinutesOrHoursFromSeconds(int seconds)
		{
			return null;
		}
	}
}
