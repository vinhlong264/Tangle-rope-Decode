using Crescive.HelperTypes;
using UnityAtoms;
using UnityEngine;

namespace Crescive
{
	[CreateAssetMenu(fileName = "StringVariableReferenceCompareCondition", menuName = "Unity Atoms/Conditions/StringVariableReferenceCompareCondition")]
	public class StringVariableReferenceCompareCondition : AtomCondition
	{
		[SerializeField]
		private StringVariableReference lhs;

		[SerializeField]
		private StringVariableReference rhs;

		[SerializeField]
		private bool trueIfEqual;

		public override bool Call()
		{
			return false;
		}
	}
}
