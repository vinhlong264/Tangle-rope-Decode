using PersistentSO;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
	[CreateAssetMenu(fileName = "PersistentFloatCompareCondition", menuName = "Unity Atoms/Conditions/PersistentFloatCompareCondition")]
	public class PersistentFloatCompareCondition : BoolCondition
	{
		[SerializeField]
		private PersistentVariable<float> referenceVariable;

		[SerializeField]
		private FloatReference compareWithVariable;

		public override bool Call()
		{
			return false;
		}
	}
}
