using System;
using System.Collections.Generic;

namespace Crescive.NewLevelFeatures
{
	[Serializable]
	public class NewLevelFeaturesData : ICloneable
	{
		public List<NewLevelFeatureData> Features;

		public NewLevelFeaturesData(List<NewLevelFeatureData> features)
		{
		}

		public NewLevelFeaturesData(NewLevelFeaturesData other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
