using UnityEngine;

namespace Crescive.Analytics
{
	public class BannerArea : MonoBehaviour
	{
		[SerializeField]
		private RectTransform area;

		public int CalculateBannerHeightIos()
		{
			return 0;
		}

		public float CalculateBannerHeightAndroid()
		{
			return 0f;
		}
	}
}
