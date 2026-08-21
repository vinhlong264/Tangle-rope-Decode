using ElephantSDK;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Ads
{
	public class CresciveRewardedAdRequester : MonoBehaviour
	{
		[Header("References")]
		[SerializeField]
		private CresciveAdsEvents adsEvents;

		[Header("Settings")]
		[SerializeField]
		private RollicRewardedAd.RewardedAdCategory category;

		[SerializeField]
		private RollicRewardedAd.RewardedAdSource source;

		[SerializeField]
		private StringConstant senderMessage;

		[SerializeField]
		private string prefix;

		[SerializeField]
		private string suffix;

		[SerializeField]
		public UnityEvent OnFailed;

		[SerializeField]
		public UnityEvent OnSkipped;

		[SerializeField]
		public UnityEvent OnFinished;

		public RollicRewardedAd.RewardedAdCategory Category => default(RollicRewardedAd.RewardedAdCategory);

		public RollicRewardedAd.RewardedAdSource Source => default(RollicRewardedAd.RewardedAdSource);

		public string SenderMessageValue => null;

		public void SetPrefix(string value)
		{
		}

		public void SetSuffix(string value)
		{
		}

		public void SetCategory(RollicRewardedAd.RewardedAdCategory value)
		{
		}

		public void SetSource(RollicRewardedAd.RewardedAdSource value)
		{
		}

		public void RequestRewarded()
		{
		}

		public void RewardedAdFailedCallback()
		{
		}

		public void RewardedAdSkippedCallback()
		{
		}

		public void RewardedAdFinishedCallback()
		{
		}

		public void SetSenderMessage(StringConstant value)
		{
		}

		public void SetSenderMessagePrefix(string value)
		{
		}

		public void SetSenderMessageSuffix(string value)
		{
		}
	}
}
