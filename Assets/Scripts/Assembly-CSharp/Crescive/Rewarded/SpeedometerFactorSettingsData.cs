using System;

namespace Crescive.Rewarded
{
	[Serializable]
	public class SpeedometerFactorSettingsData : ICloneable
	{
		public float Factor;

		public SpeedometerFactorSettingsData(float factor)
		{
		}

		public SpeedometerFactorSettingsData(SpeedometerFactorSettingsData other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
