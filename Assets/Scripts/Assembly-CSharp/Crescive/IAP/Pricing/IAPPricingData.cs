using System.Collections.Generic;
using UnityEngine;

namespace Crescive.IAP.Pricing
{
	[CreateAssetMenu(menuName = "Crescive/IAP/Pricing Data")]
	public class IAPPricingData : ScriptableObject
	{
		[SerializeField]
		private List<float> prices;

		public List<float> Prices => null;

		public static IAPPricingData GetInstance()
		{
			return null;
		}

		private void PastePricesFromClipboard()
		{
		}
	}
}
