using System;
using System.Collections.Generic;

namespace Crescive.TwistedTangle
{
	[Serializable]
	public class ConnectedRope
	{
		public RopeEntity SelfRope;

		public List<RopeEntity> Ropes;

		public List<RopeEntity> RopesWithoutSelf;

		public List<PinEntity> Pins;

		public List<PinEntity> PinsWithoutSelf;

		public int RopeCount => 0;

		public int PinCount => 0;

		public ConnectedRope(RopeEntity ropeEntity)
		{
		}

		public ConnectedRope(RopeConnection ropeConnection)
		{
		}

		~ConnectedRope()
		{
		}

		private void SubscribeConnections()
		{
		}

		private void UnsubscribeConnections()
		{
		}

		private void UpdateConnectedRope()
		{
		}

		public bool HasRope(RopeEntity ropeEntity)
		{
			return false;
		}

		public bool HasPin(PinEntity pinEntity)
		{
			return false;
		}

		public void SetRopesAndPins(RopeEntity selfRope, List<RopeEntity> ropes)
		{
		}

		public List<RopeEntity> GetRopes(bool includeSelf = true)
		{
			return null;
		}

		public List<PinEntity> GetPins(bool includeSelf = true)
		{
			return null;
		}
	}
}
