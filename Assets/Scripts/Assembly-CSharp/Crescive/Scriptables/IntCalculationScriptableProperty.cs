using System;
using System.Collections.Generic;
using Crescive.HelperTypes;
using UnityEngine;

namespace Crescive.Scriptables
{
	[CreateAssetMenu(menuName = "Crescive/Scriptables/Property/Int Calculation Scriptable Property")]
	public class IntCalculationScriptableProperty : IntScriptableProperty
	{
		[Serializable]
		public class IntCalculationData
		{
			public IntVariableReference reference;

			public CalculationType calculationType;
		}

		public List<IntCalculationData> calculations;

		private void UpdatePreviewEditorValue()
		{
		}

		protected override int GetValue()
		{
			return 0;
		}

		private void OnValidate()
		{
		}
	}
}
