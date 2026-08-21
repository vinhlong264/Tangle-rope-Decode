using System;
using UnityEngine;

namespace Crescive.Economics.DataService
{
	[Serializable]
	public class LevelEarnCoinData
	{
		public int StartValue;

		public float Increase;

		public float MinOffset;

		public float MaxOffset;

		[Range(0f, 100f)]
		public int PositiveOffsetChancePercentage;

		public float PositiveOffsetChanceProbability => 0f;

		public LevelEarnCoinData()
		{
		}

		public LevelEarnCoinData(LevelEarnCoinData plainData)
		{
		}
	}
}
