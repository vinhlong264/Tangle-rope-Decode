using System.Collections.Generic;
using Crescive.ResourceSystem;
using Crescive.TimeUtils;
using CresciveCore;
using ElephantSDK;
using PersistentSO;
using RollicGames.Advertisements;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Ads
{
	public class CresciveAdsManager : MonoBehaviour
	{
		[SerializeField]
		private PersistentBoolVariable adsEnabledDebug;

		[SerializeField]
		private CresciveAdsEvents adsEvents;

		[SerializeField]
		private LevelSystem levelSystem;

		[SerializeField]
		private TimeScaleSetter timeScaleSetter;

		[SerializeField]
		private ResourceChannel rwTicketChannel;

		[SerializeField]
		private PersistentBoolVariable isFirstInterDisplayed;

		[SerializeField]
		private FloatReference interInterInterval;

		[SerializeField]
		private FloatReference rewardedInterInterval;

		[SerializeField]
		private FloatReference firstInterDelayAfterStart;

		[SerializeField]
		private FloatReference secondAlwaysInterDelayAfterStart;

		[SerializeField]
		private IntReference firstLevelToDisplayInter;

		[SerializeField]
		private IntReference interLevelFrequency;

		[SerializeField]
		private StringConstant normalLevelType;

		[SerializeField]
		private StringVariable currentLevelType;

		[SerializeField]
		private List<LevelTypeSpecificInterIntervalData> levelTypeSpecificInterIntervals;

		[SerializeField]
		private AtomCondition bannerActiveCondition;

		[SerializeField]
		private AtomCondition interstitialActiveCondition;

		[SerializeField]
		private AtomCondition interstitialOnLevelCompleteActiveCondition;

		[SerializeField]
		private AtomCondition intersitialOnLevelFailActiveCondition;

		[SerializeField]
		private AtomCondition rewardedActiveCondition;

		private bool sdkInitialized;

		private bool lastShowIsRewarded;

		private float lastInterstitialTime;

		private int lastInterstitialLevel;

		private CresciveRewardedAdRequester _activeRewardedAdRequester;

		private bool SdkInitialized => false;

		private RLAdvertisementManager AdManager => null;

		public bool CanShowInterstitial => false;

		private bool AreInterstitialConditionsMet => false;

		private bool IsInitialInterDelayOver => false;

		private bool IsFirstInterLevelReached => false;

		private bool IsInterLevelFrequencyReached => false;

		private bool IsInterstitialIntervalOver => false;

		private bool IsFirstInterDelayOver => false;

		private bool SecondAlwaysInterDelayAfterStart => false;

		public bool CanShowBanner => false;

		public bool InterstitialReadyToBeTriggered => false;

		public bool ForcedInterstitialReadyToBeTriggered => false;

		public bool RewardedReadyToBeTriggered => false;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void EnableAds()
		{
		}

		private void DisableAds()
		{
		}

		private void AdsEnabledDebugChanged(bool value)
		{
		}

		private void InitAds()
		{
		}

		private void RegisterAdsEvents()
		{
		}

		private void UnregisterAdsEvents()
		{
		}

		private void OnRewardedVideoLoadFailedEvent(string adUnitId, string errorMessage)
		{
		}

		private void OnRewardedVideoFailedToPlayEvent()
		{
		}

		private void UpdateLastInterstitialTime()
		{
		}

		private void SetLastShowIsRewarded(bool value)
		{
		}

		private void UpdateLastInterstitialLevel()
		{
		}

		private void SetFirstInterDisplayed()
		{
		}

		private void SendRewardedVideoTappedEvent()
		{
		}

		private void SendRewardedVideoImpressionEvent()
		{
		}

		private void SendRewardedVideoCompletedEvent()
		{
		}

		private bool IsInterSourceActive(RollicInterstitialAd.InterstitialAdSource source)
		{
			return false;
		}

		private void ShowInterstitial(RollicInterstitialAd.InterstitialAdSource source)
		{
		}

		private void ShowForcedInterstitial(RollicInterstitialAd.InterstitialAdSource source)
		{
		}

		private void ShowRewarded(CresciveRewardedAdRequester rewardedAdRequester)
		{
		}

		private void OnAdsInitializedCallback()
		{
		}

		private void OnInterstitialShownCallback()
		{
		}

		private void OnInterstitialDismissedCallback()
		{
		}

		private void OnRewardedVideoShownCallback()
		{
		}

		private void OnRewardedVideoReceivedRewardCallback(string placement)
		{
		}

		private void RewardedAdResultCallback(RLRewardedAdResult result)
		{
		}

		private void TryShowBanner()
		{
		}

		private void ShowBanner()
		{
		}

		private void HideBanner()
		{
		}

		private void PauseGame()
		{
		}

		private void ContinueGame()
		{
		}

		private void RWTicketSpendSuccessfulCallback(ResourceValueEventArgs resourceValueEventArgs)
		{
		}
	}
}
