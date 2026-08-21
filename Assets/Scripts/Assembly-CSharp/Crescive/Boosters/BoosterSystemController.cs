using Crescive.ResourceSystem;
using UnityEngine;

namespace Crescive.Boosters
{
	public class BoosterSystemController : MonoBehaviour
	{
		[SerializeField]
		private BoosterSystem boosterSystem;

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

		private void OnBoosterPurchasedWithResourceCallback(BoosterChannel arg0, ResourceValueEventArgs arg1)
		{
		}
	}
}
