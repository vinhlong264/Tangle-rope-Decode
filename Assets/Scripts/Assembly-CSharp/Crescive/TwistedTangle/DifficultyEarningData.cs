using System;
using System.Collections.Generic;

namespace Crescive.TwistedTangle
{
	[Serializable]
	public class DifficultyEarningData : ICloneable
	{
		public string Difficulty;

		public int Amount;

		private List<string> Difficulties => null;

		public DifficultyEarningData(string difficulty, int amount)
		{
		}

		public DifficultyEarningData(DifficultyEarningData other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
