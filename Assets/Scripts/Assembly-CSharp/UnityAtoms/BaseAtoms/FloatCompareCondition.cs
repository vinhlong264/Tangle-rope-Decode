using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
	[CreateAssetMenu(fileName = "FloatCompareCondition", menuName = "Unity Atoms/Conditions/FloatCompareCondition")]
	public class FloatCompareCondition : FloatCondition
	{
		[SerializeField]
		[Header("Settings")]
		private FloatReference rhs;

		[SerializeField]
		private NumberCompareOperator compareOperator;

		[SerializeField]
		private float equalityTolerance;

		public override bool Call(float lhs)
		{
			return false;
		}
	}
}
