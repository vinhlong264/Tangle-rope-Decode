using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
	[CreateAssetMenu(fileName = "IntCompareCondition", menuName = "Unity Atoms/Conditions/IntCompareCondition")]
	public class IntCompareCondition : IntCondition
	{
		[Header("Settings")]
		[SerializeField]
		private IntReference rhs;

		[SerializeField]
		private NumberCompareOperator compareOperator;

		public override bool Call(int lhs)
		{
			return false;
		}
	}
}
