using System.Collections.Generic;
using MyBox;
using UnityEngine;

namespace Crescive.Leveling
{
	public abstract class BaseLevelingFloatCalculator : LevelingVariableCalculator<float>
	{
		[SerializeField]
		private Vector2 clampMinMax;

		[PositiveValueOnly]
		[SerializeField]
		public int previewCurveMaxLevel;

		public override float Calculate(int level)
		{
			return 0f;
		}

		public List<float> CalculateValues(int maxLevel)
		{
			return null;
		}

		public float CalculateMinValue(int maxLevel)
		{
			return 0f;
		}

		public float CalculateMaxValue(int maxLevel)
		{
			return 0f;
		}

		protected abstract float CalculateInternal(int level);
	}
}
