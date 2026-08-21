using System;

namespace Crescive.RaceSystem
{
	[Serializable]
	public class NpcRacerData : RacerData
	{
		public int StartCompletion;

		public int FinalCompletion;

		public NpcRacerData(string racerId, int completion, int startCompletion, int finalCompletion)
			: base(null, 0)
		{
		}

		public NpcRacerData(NpcRacerData other)
			: base(null, 0)
		{
		}
	}
}
