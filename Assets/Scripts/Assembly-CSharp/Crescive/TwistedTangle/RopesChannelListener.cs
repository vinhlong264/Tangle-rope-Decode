using Crescive.Channels;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public class RopesChannelListener : ObjectsChannelListener<RopeEntity, RopesChannel>
	{
		public UnityEvent<RopeEntity> OnRopeMerged;

		public UnityEvent<Vector3> OnRopeJumpedToMerge;

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void UpdateListeningEvents()
		{
		}

		private void SubscribeToEvents()
		{
		}

		private void UnsubscribeFromEvents()
		{
		}
	}
}
