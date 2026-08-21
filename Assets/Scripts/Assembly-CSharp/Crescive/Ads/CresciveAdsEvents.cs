using ElephantSDK;
using PersistentSO;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Ads
{
	[CreateAssetMenu(fileName = "CresciveAdsEvents", menuName = "Crescive/Ads/Events/CresciveAdsEvents")]
	public class CresciveAdsEvents : ScriptableObject
	{
		[SerializeField]
		private CresciveAdsManager adsManager;

		[SerializeField]
		private PersistentBoolVariable adsEnabledDebug;

		[Header("Enable Disable Events")]
		public UnityEvent OnEnableAds;

		[Header("Enable Disable Events")]
		public UnityEvent OnDisableAds;

		[Header("Request Events")]
		public UnityEvent<RollicInterstitialAd.InterstitialAdSource> OnRequestInterstitial;

		[Header("Request Events")]
		public UnityEvent<RollicInterstitialAd.InterstitialAdSource> OnRequestForcedInterstitial;

		[Header("Request Events")]
		public UnityEvent<CresciveRewardedAdRequester> OnRequestRewarded;

		[Header("Request Events")]
		public UnityEvent OnRequestShowBanner;

		[Header("Request Events")]
		public UnityEvent OnRequestHideBanner;

		[Header("Request Events")]
		public UnityEvent OnBannerShown;

		[Header("Request Events")]
		public UnityEvent OnBannerHidden;

		public UnityEvent OnInterShown;

		public UnityEvent OnInterFinished;

		public UnityEvent<CresciveRewardedAdRequester> OnRwFailed;

		public UnityEvent<CresciveRewardedAdRequester> OnRwSkipped;

		public UnityEvent<CresciveRewardedAdRequester> OnRwFinished;

		public CresciveAdsManager AdsManager
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void RequestInterstitial(RollicInterstitialAd.InterstitialAdSource source)
		{
		}

		public void RequestInterstitial(RollicInterAdSource source)
		{
		}

		public void RequestForcedInterstitial(RollicInterstitialAd.InterstitialAdSource source)
		{
		}

		public void RequestShowBanner()
		{
		}

		public void RequestHideBanner()
		{
		}

		public void EnableAds()
		{
		}

		public void DisableAds()
		{
		}

		public void RequestRewarded(CresciveRewardedAdRequester requester)
		{
		}

		public void TriggerInterShown()
		{
		}

		public void TriggerInterstitialFinished()
		{
		}

		public void TriggerRwFailed(CresciveRewardedAdRequester requester)
		{
		}

		public void TriggerRwSkipped(CresciveRewardedAdRequester requester)
		{
		}

		public void TriggerRwFinished(CresciveRewardedAdRequester requester)
		{
		}

		public void TriggerBannerShown()
		{
		}

		public void TriggerBannerHidden()
		{
		}
	}
}
