using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
	[CreateAssetMenu(fileName = "CompositeAtomConditionsCondition", menuName = "Unity Atoms/Conditions/CompositeAtomConditionsCondition")]
	public class CompositeAtomConditionsCondition : AtomCondition
	{
		public bool Test;

		[SerializeField]
		private List<CompositeAtomConditionData> conditions;

		public override bool Call()
		{
			return false;
		}
	}
}
