using System;
using Crescive.HelperTypes;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.ResourceSystem
{
	public class ResourceChannelListener : MonoBehaviour
	{
		private enum EventTriggerTime
		{
			None = 0,
			OnAwake = 1,
			OnEnable = 2,
			OnStart = 3
		}

		[SerializeField]
		private ResourceChannel resourceChannel;

		[SerializeField]
		[Obsolete("Use onChangedAutoTriggerMethod instead")]
		private EventTriggerTime initialChangedTriggerTime;

		[SerializeField]
		private AutoTriggerMethod onChangedAutoTriggerMethod;

		[SerializeField]
		private UnityEvent<float> OnChanged;

		[SerializeField]
		private UnityEvent<ResourceValueEventArgs> OnSet;

		[SerializeField]
		private UnityEvent<ResourceValueEventArgs> OnIncreased;

		[SerializeField]
		private UnityEvent<ResourceValueEventArgs> OnDecreased;

		[SerializeField]
		private UnityEvent<float> OnSetValue;

		[SerializeField]
		private UnityEvent<float> OnIncreasedValue;

		[SerializeField]
		private UnityEvent<float> OnDecreasedValue;

		[SerializeField]
		private UnityEvent<ResourceValueEventArgs> OnSpendSuccessful;

		[SerializeField]
		private UnityEvent<ResourceValueEventArgs> OnSpendFailed;

		[SerializeField]
		private UnityEvent<bool> OnIsInfiniteChanged;

		[SerializeField]
		private UnityEvent<bool> OnIsInfiniteChangedReverse;

		[SerializeField]
		private UnityEvent OnIsInfinite;

		[SerializeField]
		private UnityEvent OnIsNotInfinite;

		[SerializeField]
		private UnityEvent<bool> OnIsTemporaryInfiniteChanged;

		[SerializeField]
		private UnityEvent OnIsTemporaryInfinite;

		[SerializeField]
		private UnityEvent OnIsNotTemporaryInfinite;

		[SerializeField]
		private UnityEvent<int> OnTemporaryInfiniteSecondsChanged;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		private void SubscribeChannelEvents()
		{
		}

		private void UnsubscribeChannelEvents()
		{
		}

		private void TriggerEvents()
		{
		}

		private void OnChangedCallback(float value)
		{
		}

		private void TriggerInfinityEvents()
		{
		}

		private void OnIsInfiniteChangedCallback(bool isInfinite)
		{
		}

		private void OnSetCallback(ResourceValueEventArgs args)
		{
		}

		private void OnIncreasedCallback(ResourceValueEventArgs args)
		{
		}

		private void OnDecreasedCallback(ResourceValueEventArgs args)
		{
		}

		private void OnSpendSuccessfulCallback(ResourceValueEventArgs args)
		{
		}

		private void OnSpendFailedCallback(ResourceValueEventArgs args)
		{
		}

		public void SetChannel(ResourceChannel channel)
		{
		}
	}
}
