using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
	[CreateAssetMenu(menuName = "Unity Atoms/Conditions/Reverse Atom Condition")]
	public class ReverseAtomCondition : AtomCondition
	{
		[SerializeField]
		private AtomCondition condition;

		public override bool Call()
		{
			return false;
		}
	}
}
