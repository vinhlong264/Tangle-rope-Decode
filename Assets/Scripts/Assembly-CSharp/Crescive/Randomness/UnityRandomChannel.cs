using UnityEngine;

namespace Crescive.Randomness
{
	[CreateAssetMenu(fileName = "UnityRandomChannel", menuName = "Crescive/Randomness/UnityRandomChannel")]
	public class UnityRandomChannel : RandomChannel
	{
		private UnityRandomWrapper unityRandomWrapper;

		public override void Setup()
		{
		}

		public override void SetupWithSeed(int seed)
		{
		}

		public override int Next(int min, int maxExcluded)
		{
			return 0;
		}

		public override float NextFloat(float min, float max)
		{
			return 0f;
		}
	}
}
