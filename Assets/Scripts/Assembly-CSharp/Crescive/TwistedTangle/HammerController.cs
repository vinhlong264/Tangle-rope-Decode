using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public class HammerController : MonoBehaviour
	{
		[SerializeField]
		private HammerControllerChannel hammerControllerChannel;

		[SerializeField]
		private PinsChannel pinsChannel;

		[SerializeField]
		private RopesChannel ropesChannel;

		[SerializeField]
		[Space]
		private float mergeDelay;

		[SerializeField]
		private float scaleDuration;

		[SerializeField]
		private float externalForceMagnitude;

		private PinEntity chosenPin;

		public UnityEvent<PinEntity> OnPinChosen;

		private void CutActually()
		{
		}

		private void DestroyChosenPinObsolute()
		{
		}

		private void DestroyChosenPinTriedWithAffectedPins()
		{
		}

		public void ChooseRandomPinAndStartAnimation()
		{
		}

		public void DestroyChosenPin()
		{
		}
	}
}
