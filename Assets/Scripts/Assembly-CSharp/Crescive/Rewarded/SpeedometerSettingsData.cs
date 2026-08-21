using System;
using System.Collections.Generic;

namespace Crescive.Rewarded
{
	[Serializable]
	public class SpeedometerSettingsData : ICloneable
	{
		public List<SpeedometerFactorSettingsData> FactorSettings;

		public SpeedometerSettingsData(List<SpeedometerFactorSettingsData> factorSettings)
		{
		}

		public SpeedometerSettingsData(SpeedometerSettingsData other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
