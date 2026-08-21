using System;
using System.Collections.Generic;

namespace Crescive.RaceSystem
{
	[Serializable]
	public class NpcRacersData
	{
		public List<NpcRacerData> Racers;

		public List<RacerData> BaseRacers => null;

		public NpcRacersData()
		{
		}

		public NpcRacersData(List<NpcRacerData> racers)
		{
		}

		public NpcRacersData(NpcRacersData other)
		{
		}
	}
}
