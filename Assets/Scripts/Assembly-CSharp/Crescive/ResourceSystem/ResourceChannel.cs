using Crescive.BoolSystem;
using Crescive.ResourceSystem.UI;
using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.ResourceSystem
{
	[CreateAssetMenu(fileName = "Resource Channel", menuName = "Crescive/Resource System/Channels/Resource Channel")]
	public class ResourceChannel : PersistentFloatVariable
	{
		[SerializeField]
		private ResourceAnimation defaultResourceAnimation;

		[SerializeField]
		private TimedBoolVariable infiniteVariable;

		[SerializeField]
		internal Sprite Icon;

		[SerializeField]
		internal Sprite InfiniteIcon;

		public UnityEvent<ResourceValueEventArgs> OnSet;

		public UnityEvent<ResourceValueEventArgs> OnIncreased;

		public UnityEvent<ResourceValueEventArgs> OnDecreased;

		public UnityEvent<ResourceValueEventArgs> OnSpendSuccessful;

		public UnityEvent<ResourceValueEventArgs> OnSpendFailed;

		public UnityEvent<ResourceValueEventArgs> OnCoinIncreaseAnimationTriggered;

		public UnityEvent<ResourceValueEventArgs> OnCoinDecreaseAnimationTriggered;

		[field: SerializeField]
		public StringReference TypeId { get; private set; }

		[field: SerializeField]
		public ProductType ProductType { get; private set; }

		public ResourceAnimation DefaultResourceAnimation => null;

		public bool IsInfinite => false;

		public TimedBoolVariable InfiniteVariable => null;

		public int IntValue => 0;

		public int SessionStartIntValue => 0;

		public UnityEvent<bool> IsInfiniteChanged => null;

		public void SetValue(ResourceValueEventArgs args)
		{
		}

		public void IncreaseValue(ResourceValueEventArgs args)
		{
		}

		public void DecreaseValue(ResourceValueEventArgs args)
		{
		}

		public void SetValue(float amount)
		{
		}

		public void IncreaseValue(float amount)
		{
		}

		public void DecreaseValue(float amount)
		{
		}

		public void SetValue(int amount)
		{
		}

		public void IncreaseValue(int amount)
		{
		}

		public void DecreaseValue(int amount)
		{
		}

		public bool CanSpendAmount(float amount)
		{
			return false;
		}

		public bool TrySpend(ResourceValueEventArgs args)
		{
			return false;
		}

		public void SetIsInfinite(bool infinite)
		{
		}

		public int GetTotalTransactionAmount()
		{
			return 0;
		}

		public int GetSessionTransactionAmount()
		{
			return 0;
		}

		public void TriggerCoinIncreaseAnimation(ResourceValueEventArgs args)
		{
		}

		public void TriggerCoinDecreaseAnimation(ResourceValueEventArgs args)
		{
		}
	}
}
