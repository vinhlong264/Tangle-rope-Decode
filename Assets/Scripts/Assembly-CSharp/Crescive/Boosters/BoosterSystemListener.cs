using System.Collections.Generic;
using Crescive.ResourceSystem;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Boosters
{
	public class BoosterSystemListener : MonoBehaviour
	{
		[SerializeField]
		private BoosterSystem boosterSystem;

		[SerializeField]
		private List<BoosterChannel> exceptedBoosters;

		[SerializeField]
		private List<BoosterChannel> includedBoosters;

		public UnityEvent<BoosterChannel> OnRequested;

		public UnityEvent<BoosterChannel> OnStarted;

		public UnityEvent<BoosterChannel> OnCanceled;

		public UnityEvent<BoosterChannel> OnPerformed;

		public UnityEvent<BoosterChannel> OnFinished;

		public UnityEvent<BoosterChannel> OnCanceledOrFinished;

		public UnityEvent<BoosterChannel> OnResourceNotEnough;

		public UnityEvent<BoosterChannel, ResourceValueEventArgs> OnBoosterPurchasedWithResource;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnBoosterRequestedCallback(BoosterChannel boosterChannel)
		{
		}

		private void OnBoosterStartedCallback(BoosterChannel boosterChannel)
		{
		}

		private void OnBoosterCanceledCallback(BoosterChannel boosterChannel)
		{
		}

		private void OnBoosterPerformedCallback(BoosterChannel boosterChannel)
		{
		}

		private void OnBoosterFinishedCallback(BoosterChannel boosterChannel)
		{
		}

		private void OnBoosterCanceledOrFinishedCallback(BoosterChannel boosterChannel)
		{
		}

		private void OnResourceNotEnoughCallback(BoosterChannel boosterChannel)
		{
		}

		private void OnBoosterPurchasedWithResourceCallback(BoosterChannel boosterChannel, ResourceValueEventArgs args)
		{
		}

		private bool IsBoosterChannelValid(BoosterChannel boosterChannel)
		{
			return false;
		}
	}
}
