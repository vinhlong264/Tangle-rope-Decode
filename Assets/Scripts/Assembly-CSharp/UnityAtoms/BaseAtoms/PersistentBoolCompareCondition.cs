using PersistentSO;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
	[CreateAssetMenu(fileName = "PersistentBoolCompareCondition", menuName = "Unity Atoms/Conditions/PersistentBoolCompareCondition")]
	public class PersistentBoolCompareCondition : AtomCondition
	{
		[SerializeField]
		private PersistentBoolVariable variable;

		[SerializeField]
		private BoolReference comparedValue;

		public override bool Call()
		{
			return false;
		}
	}
}
