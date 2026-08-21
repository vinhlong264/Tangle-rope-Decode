using Crescive.ResourceSystem;
using ElephantSDK;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Ads
{
	public class RewardedResourceSpenderDelegate : MonoBehaviour
	{
		[SerializeField]
		private RewardedResourceSpender spender;

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

		public UnityEvent OnSpentResource;

		public UnityEvent OnSpentRW;

		public UnityEvent OnSpentFailed;

		public UnityEvent OnSpendOperationFinished;

		public UnityEvent OnRewardedSkipped;

		public bool CanSpend => false;

		public ResourceChannel ResourceChannel => null;

		private void Awake()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		private void Setup()
		{
		}

		public void TrySpend()
		{
		}

		public void TrySpendWorldPosition()
		{
		}

		public void TrySpendCanvasPosition()
		{
		}

		public void SetSpendInfo(StringConstant spendInfo)
		{
		}

		public void SetSenderMessage(StringConstant senderMessage)
		{
		}

		public void SetSenderMessagePrefix(string senderMessagePrefix)
		{
		}

		public void SetSenderMessagePrefix(StringConstant senderMessagePrefix)
		{
		}

		public void SetSenderMessageSuffix(string senderMessageSuffix)
		{
		}

		public void SetSenderMessageSuffix(StringConstant senderMessageSuffix)
		{
		}
	}
}
