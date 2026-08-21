using System;

namespace DynamicQuestTime
{
	[Serializable]
	public class DynamicQuestTimeData
	{
		public bool[] IsClaimedList;

		public int Progression;

		public string LastStartedDate;

		public DateTime LastDate;

		public int PendingToken;

		public bool IsFirstTimePopped;

		public bool IsTutorialDone;
	}
}
