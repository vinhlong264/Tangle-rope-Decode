using System;
using System.Collections.Generic;
using Crescive.HelperTypes;
using UnityEngine;

namespace Crescive.Scriptables
{
	[CreateAssetMenu(menuName = "Crescive/Scriptables/Property/Float Calculation Scriptable Property")]
	public class FloatCalculationScriptableProperty : FloatScriptableProperty
	{
		[Serializable]
		public class FloatCalculationData
		{
			public FloatVariableReference reference;

			public CalculationType calculationType;
		}

		public List<FloatCalculationData> calculations;

		private void UpdatePreviewEditorValue()
		{
		}

		protected override float GetValue()
		{
			return 0f;
		}

		private void OnValidate()
		{
		}
	}
}
