using ElephantSDK;
using UnityEngine;

namespace Crescive.Ads
{
	[CreateAssetMenu(fileName = "RollicInterAdSource", menuName = "Crescive/Ads/Rollic/InterAdSource")]
	public class RollicInterAdSource : ScriptableObject
	{
		[field: SerializeField]
		public RollicInterstitialAd.InterstitialAdSource Value { get; private set; }
	}
}
