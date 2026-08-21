using System;
using UnityEngine;

namespace Crescive.Randomness
{
	[CreateAssetMenu(fileName = "SystemRandomChannel", menuName = "Crescive/Randomness/SystemRandomChannel")]
	public class SystemRandomChannel : RandomChannel
	{
		private SystemRandomWrapper systemRandomWrapper;

		public System.Random Random => null;

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
