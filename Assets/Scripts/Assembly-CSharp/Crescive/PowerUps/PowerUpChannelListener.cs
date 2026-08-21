using UnityEngine;
using UnityEngine.Events;

namespace Crescive.PowerUps
{
	public class PowerUpChannelListener : MonoBehaviour
	{
		[SerializeField]
		private PowerUpChannel powerUpChannel;

		public UnityEvent<PowerUpChannel> OnStarted;

		public UnityEvent<PowerUpChannel> OnCanceled;

		public UnityEvent<PowerUpChannel> OnPerformed;

		public UnityEvent<PowerUpChannel> OnFinished;

		public UnityEvent<PowerUpChannel> OnCanceledOrFinished;

		public UnityEvent<PowerUpChannel> OnResourceNotEnough;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
