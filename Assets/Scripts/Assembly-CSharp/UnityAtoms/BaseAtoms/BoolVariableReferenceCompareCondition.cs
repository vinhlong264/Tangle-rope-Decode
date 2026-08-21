using Crescive.HelperTypes;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
	[CreateAssetMenu(fileName = "BoolVariableReferenceCompareCondition", menuName = "Unity Atoms/Conditions/BoolVariableReferenceCompareCondition")]
	public class BoolVariableReferenceCompareCondition : AtomCondition
	{
		[SerializeField]
		private BoolVariableReference variableReference;

		[SerializeField]
		private BoolReference comparedValue;

		public override bool Call()
		{
			return false;
		}
	}
}
