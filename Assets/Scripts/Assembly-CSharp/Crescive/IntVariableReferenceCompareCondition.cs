using Crescive.HelperTypes;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive
{
	[CreateAssetMenu(fileName = "IntVariableReferenceCompareCondition", menuName = "Unity Atoms/Conditions/IntVariableReferenceCompareCondition")]
	public class IntVariableReferenceCompareCondition : AtomCondition
	{
		[SerializeField]
		private IntVariableReference lhs;

		[SerializeField]
		private IntVariableReference rhs;

		[SerializeField]
		private NumberCompareOperator compareOperator;

		public override bool Call()
		{
			return false;
		}
	}
}
