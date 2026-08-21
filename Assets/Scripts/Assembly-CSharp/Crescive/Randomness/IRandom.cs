namespace Crescive.Randomness
{
	public interface IRandom
	{
		void Setup();

		void SetupWithSeed(int seed);

		int Next(int min, int maxExcluded);

		float NextFloat(float min, float max);
	}
}
