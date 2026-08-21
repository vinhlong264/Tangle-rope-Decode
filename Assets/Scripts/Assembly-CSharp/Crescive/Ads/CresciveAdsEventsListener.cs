using ElephantSDK;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Ads
{
	public class CresciveAdsEventsListener : MonoBehaviour
	{
		[SerializeField]
		private CresciveAdsEvents adsEvents;

		[SerializeField]
		private UnityEvent<RollicInterstitialAd.InterstitialAdSource> OnRequestInterstitial;

		[SerializeField]
		private UnityEvent<RollicInterstitialAd.InterstitialAdSource> OnRequestForcedInterstitial;

		[SerializeField]
		private UnityEvent<CresciveRewardedAdRequester> OnRequestRewarded;

		[SerializeField]
		private UnityEvent OnRequestShowBanner;

		[SerializeField]
		private UnityEvent OnRequestHideBanner;

		[SerializeField]
		private UnityEvent OnInterShown;

		[SerializeField]
		private UnityEvent OnInterFinished;

		[SerializeField]
		private UnityEvent<CresciveRewardedAdRequester> OnRwFailed;

		[SerializeField]
		private UnityEvent<CresciveRewardedAdRequester> OnRwSkipped;

		[SerializeField]
		private UnityEvent<CresciveRewardedAdRequester> OnRwFinished;

		[SerializeField]
		private UnityEvent<string> OnRwFailedWithMessage;

		[SerializeField]
		private UnityEvent<string> OnRwSkippedWithMessage;

		[SerializeField]
		private UnityEvent<string> OnRwFinishedWithMessage;

		public UnityEvent OnBannerShown;

		public UnityEvent OnBannerHidden;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void TriggerRequestInterstitial(RollicInterstitialAd.InterstitialAdSource source)
		{
		}

		public void TriggerRequestForcedInterstitial(RollicInterstitialAd.InterstitialAdSource source)
		{
		}

		public void TriggerRequestShowBanner()
		{
		}

		public void TriggerRequestHideBanner()
		{
		}

		public void TriggerRequestRewarded(CresciveRewardedAdRequester requester)
		{
		}

		public void TriggerInterShown()
		{
		}

		public void TriggerInterFinished()
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
