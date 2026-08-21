using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Leveling
{
	[CreateAssetMenu(menuName = "ScriptableObjects/Leveling/Calculators/LinearLevelingFloatCalculator", fileName = "LinearLevelingFloatCalculator")]
	public class LinearLevelingFloatCalculator : BaseLevelingFloatCalculator
	{
		[SerializeField]
		private float startValue;

		[SerializeField]
		private float increaseValue;

		[SerializeField]
		private FloatReference increaseValueLevelMultiplier;

		protected override float CalculateInternal(int level)
		{
			return 0f;
		}
	}
}
