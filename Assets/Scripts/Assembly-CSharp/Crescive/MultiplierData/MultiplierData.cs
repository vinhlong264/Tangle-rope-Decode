using System;

namespace Crescive.MultiplierData
{
	[Serializable]
	public class MultiplierData : ICloneable
	{
		public string Id;

		public float Multiplier;

		public MultiplierData(string id, float multiplier, bool enabled)
		{
		}

		public MultiplierData(MultiplierData data)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
