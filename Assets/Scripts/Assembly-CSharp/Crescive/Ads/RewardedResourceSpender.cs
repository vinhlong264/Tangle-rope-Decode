using System.Collections.Generic;
using Crescive.ResourceSystem;
using ElephantSDK;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Ads
{
	public class RewardedResourceSpender : MonoBehaviour
	{
		[SerializeField]
		private ResourceSpendBehaviour spender;

		[SerializeField]
		private CresciveRewardedAdRequester adRequester;

		[SerializeField]
		private List<ResourceChannelListener> resourceListeners;

		[SerializeField]
		private ResourceChannel resourceChannel;

		[SerializeField]
		private StringConstant spendInfo;

		[SerializeField]
		private RollicRewardedAd.RewardedAdCategory category;

		[SerializeField]
		private RollicRewardedAd.RewardedAdSource source;

		[SerializeField]
		private StringConstant senderMessage;

		[SerializeField]
		private string senderMessagePrefix;

		[SerializeField]
		private string senderMessageSuffix;

		public UnityEvent OnTrySpend;

		public UnityEvent OnSpent;

		public UnityEvent OnSpentRW;

		public UnityEvent OnSpentResource;

		public UnityEvent OnSpentFailed;

		public UnityEvent OnRewardedSkipped;

		public bool CanSpend => false;

		public ResourceChannel ResourceChannel => null;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SubscribeToResourceSpender()
		{
		}

		private void UnsubscribeFromResourceSpender()
		{
		}

		private void SubscribeToAdRequester()
		{
		}

		private void UnsubscribeFromAdRequester()
		{
		}

		private void SetupSpender()
		{
		}

		private void SetupAdRequester()
		{
		}

		private void SetupListeners()
		{
		}

		private void Setup()
		{
		}

		private void OnSpendSuccessfulCallback()
		{
		}

		private void OnSpendFailedCallback()
		{
		}

		private void OnRewardedFinishedCallback()
		{
		}

		private void OnRewardedSkippedCallback()
		{
		}

		private void OnRewardedFailedCallback()
		{
		}

		private void PerformSpent(bool didSpendResource)
		{
		}

		private void PerformFailed()
		{
		}

		public void SetResourceChannel(ResourceChannel value)
		{
		}

		public void SetSpendInfo(StringConstant constant)
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

		public void SetCategory(RollicRewardedAd.RewardedAdCategory value)
		{
		}

		public void SetSource(RollicRewardedAd.RewardedAdSource value)
		{
		}

		public void TrySpend()
		{
		}

		public void TrySpendWorldPosition()
		{
		}

		public void TrySpendCanvasPosition(string info)
		{
		}
	}
}
