using System;

namespace Crescive.OnlineLevels
{
	[Serializable]
	public class OnlineLevelData : ICloneable
	{
		public int Number;

		public string Id;

		public OnlineLevelData(int number, string id)
		{
		}

		public OnlineLevelData(OnlineLevelData other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
