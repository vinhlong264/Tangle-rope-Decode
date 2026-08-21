using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
	[CreateAssetMenu(fileName = "IntReferenceEvenOddCondition", menuName = "Unity Atoms/Conditions/IntReferenceEvenOddCondition")]
	public class IntReferenceEvenOddCondition : AtomCondition
	{
		[SerializeField]
		private IntReference reference;

		[SerializeField]
		private bool isEven;

		public override bool Call()
		{
			return false;
		}
	}
}
