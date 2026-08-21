using UnityEngine;

namespace Crescive.Randomness
{
	public abstract class RandomChannel : ScriptableObject, IRandom
	{
		public abstract void Setup();

		public abstract void SetupWithSeed(int seed);

		public abstract int Next(int min, int maxExcluded);

		public abstract float NextFloat(float min, float max);
	}
}
