using System;

namespace Crescive.RaceSystem
{
	[Serializable]
	public class RacerData
	{
		public string RacerId;

		public int Completion;

		public RacerData(string racerId, int completion)
		{
		}

		public RacerData(RacerData other)
		{
		}
	}
}
