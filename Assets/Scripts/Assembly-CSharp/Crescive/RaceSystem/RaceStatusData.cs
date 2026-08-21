using System;

namespace Crescive.RaceSystem
{
	[Serializable]
	public struct RaceStatusData
	{
		public RaceStatus Status;

		public RaceStatusData(RaceStatus status)
		{
			Status = default(RaceStatus);
		}
	}
}
