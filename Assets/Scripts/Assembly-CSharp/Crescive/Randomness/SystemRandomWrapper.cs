using System;

namespace Crescive.Randomness
{
	public class SystemRandomWrapper : IRandom
	{
		public Random Random { get; private set; }

		public SystemRandomWrapper()
		{
		}

		public SystemRandomWrapper(int seed)
		{
		}

		public void Setup()
		{
		}

		public void SetupWithSeed(int seed)
		{
		}

		public int Next(int min, int maxExcluded)
		{
			return 0;
		}

		public float NextFloat(float min, float max)
		{
			return 0f;
		}
	}
}
