using System;

namespace Crescive.ResourceSystem
{
	[Serializable]
	public class ResourceGeneratorData
	{
		public float GenerateIntervalMinutes;

		public float MaxValue;

		public ResourceGeneratorData(ResourceGeneratorData other)
		{
		}
	}
}
