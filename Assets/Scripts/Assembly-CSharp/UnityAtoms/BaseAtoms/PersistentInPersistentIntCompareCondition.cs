using PersistentSO;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
	[CreateAssetMenu(fileName = "PersistentInPersistentIntCompareCondition", menuName = "Unity Atoms/Conditions/PersistentInPersistentIntCompareCondition")]
	public class PersistentInPersistentIntCompareCondition : AtomCondition
	{
		[SerializeField]
		private PersistentIntVariable variable;

		[SerializeField]
		private PersistentIntVariable compareWithVariable;

		[SerializeField]
		private CompareType compareType;

		public override bool Call()
		{
			return false;
		}
	}
}
