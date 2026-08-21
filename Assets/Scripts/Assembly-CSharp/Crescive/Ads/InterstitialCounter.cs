using PersistentSO;
using UnityEngine;

namespace Crescive.Ads
{
	public class InterstitialCounter : MonoBehaviour
	{
		[SerializeField]
		private PersistentIntVariable interCount;

		public void OnInterstitialDisplayed()
		{
		}
	}
}
