using Crescive.HelperTypes;
using UnityAtoms;
using UnityEngine;

namespace Crescive
{
	[CreateAssetMenu(fileName = "IntVariableReferenceMinMaxCondition", menuName = "Unity Atoms/Conditions/IntVariableReferenceMinMaxCondition")]
	public class IntVariableReferenceMinMaxCondition : AtomCondition
	{
		[SerializeField]
		private IntVariableReference variable;

		[SerializeField]
		private IntVariableReference min;

		[SerializeField]
		private IntVariableReference max;

		public override bool Call()
		{
			return false;
		}
	}
}
