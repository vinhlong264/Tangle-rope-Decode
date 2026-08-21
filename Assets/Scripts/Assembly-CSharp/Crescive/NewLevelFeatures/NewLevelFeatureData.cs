using System;

namespace Crescive.NewLevelFeatures
{
	[Serializable]
	public class NewLevelFeatureData : ICloneable
	{
		public int LevelNumber;

		public NewLevelFeatureData(int levelNumber)
		{
		}

		public NewLevelFeatureData(NewLevelFeatureData other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
