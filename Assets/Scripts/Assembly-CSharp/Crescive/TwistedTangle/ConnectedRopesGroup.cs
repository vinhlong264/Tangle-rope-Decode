using System;
using System.Collections.Generic;

namespace Crescive.TwistedTangle
{
	[Serializable]
	public class ConnectedRopesGroup
	{
		public List<ConnectedRope> ConnectedRopes;

		public int ConnectedRopesCount => 0;

		public int PinsCountForOneConnectedRope => 0;

		public ConnectedRopesGroup(List<ConnectedRope> connectedRopes)
		{
		}
	}
}
