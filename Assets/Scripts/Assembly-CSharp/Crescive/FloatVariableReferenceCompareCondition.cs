using Crescive.HelperTypes;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive
{
	[CreateAssetMenu(fileName = "FloatVariableReferenceCompareCondition", menuName = "Unity Atoms/Conditions/FloatVariableReferenceCompareCondition")]
	public class FloatVariableReferenceCompareCondition : AtomCondition
	{
		[SerializeField]
		private FloatVariableReference lhs;

		[SerializeField]
		private FloatVariableReference rhs;

		[SerializeField]
		private NumberCompareOperator compareOperator;

		public override bool Call()
		{
			return false;
		}
	}
}
