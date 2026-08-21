using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Leveling
{
	[CreateAssetMenu(menuName = "ScriptableObjects/Leveling/Calculators/ListLevelingFloatCalculator", fileName = "ListLevelingFloatCalculator")]
	public class ListLevelingFloatCalculator : BaseLevelingFloatCalculator
	{
		[SerializeField]
		[Header("Settings")]
		private bool startAtLevelOne;

		[Space]
		[SerializeField]
		private List<float> values;

		[Header("Multiplier")]
		[SerializeField]
		private LevelingFloatCalculatorMultiplierType multiplierType;

		[SerializeField]
		private FloatReference percentMultiplierReference;

		[SerializeField]
		private LevelingFloat percentMultiplierLeveling;

		[SerializeField]
		private BaseLevelingFloatCalculator percentMultiplierCalculator;

		protected override float CalculateInternal(int level)
		{
			return 0f;
		}

		private float GetPercentMultiplier(int level)
		{
			return 0f;
		}
	}
}
