using System;
using System.Collections.Generic;

namespace Systems.Randomization.Scripts
{
	[Serializable]
	public class RandomizationData : ICloneable
	{
		public bool isRandomizationEnabled;

		public bool isPatternActiveAtStageLevel;

		public int levelLimit;

		public List<PlayPattern> patterns;

		private RandomizationData(RandomizationData randomizationData)
		{
		}

		public object Clone()
		{
			return null;
		}

		public bool IsValidPattern(PlayPattern pattern)
		{
			return false;
		}

		public bool IsInvalidPattern(PlayPattern pattern)
		{
			return false;
		}

		public bool IsValidPatternAtStageLevel(PlayPattern pattern)
		{
			return false;
		}

		public bool IsInvalidPatternAtStageLevel(PlayPattern pattern)
		{
			return false;
		}

		public bool IsValidRandomization()
		{
			return false;
		}

		public bool IsInvalidRandomization()
		{
			return false;
		}
	}
}
