using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Leveling
{
	public class FloatCalculatorBehaviour : MonoBehaviour
	{
		[SerializeField]
		private BaseLevelingFloatCalculator calculator;

		public UnityEvent<float> OnCalculated;

		public UnityEvent<int> OnCalculatedRoundToInt;

		public void CalculateForLevel(int level)
		{
		}
	}
}
