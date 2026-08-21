using System.Collections.Generic;
using MyBox;
using UnityEngine;

namespace Crescive.Leveling
{
	[CreateAssetMenu(menuName = "ScriptableObjects/Leveling/Calculators/ParameterizedLevelingFloatCalculator", fileName = "ParameterizedLevelingFloatCalculator")]
	public class ParameterizedLevelingFloatCalculator : BaseLevelingFloatCalculator
	{
		[PositiveValueOnly]
		[SerializeField]
		private int maxPreviewTextLevel;

		[SerializeField]
		private float startValue;

		[SerializeField]
		private List<ReferencedValueModifierData> startValueModifiers;

		[SerializeField]
		private List<ReferencedValueModifierData> endValueModifiers;

		[SerializeField]
		private bool repeatLastModifier;

		[SerializeField]
		private List<ValueModifierData> valueModifiers;

		protected override float CalculateInternal(int level)
		{
			return 0f;
		}

		private float GetStartValue()
		{
			return 0f;
		}

		private float GetEndValue(float calculatedValue)
		{
			return 0f;
		}

		private ValueModifierData GetValueModifierForLevel(int level)
		{
			return default(ValueModifierData);
		}

		private ValueModifierData AddNewValueModifier()
		{
			return default(ValueModifierData);
		}
	}
}
