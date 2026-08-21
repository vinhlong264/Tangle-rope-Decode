using System;
using System.Collections.Generic;

namespace Crescive.CreatorMode
{
	[Serializable]
	public class RopeWithPinsData
	{
		public List<PinData> Pins;

		public RopeData Rope;

		public RopeWithPinsData(RopeData rope, List<PinData> pins)
		{
		}
	}
}
