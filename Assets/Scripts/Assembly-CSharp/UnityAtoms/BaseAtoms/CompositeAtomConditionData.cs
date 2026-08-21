using System;

namespace UnityAtoms.BaseAtoms
{
	[Serializable]
	public struct CompositeAtomConditionData
	{
		public AtomCondition condition;

		public BoolCompareOperator boolCompareOperator;
	}
}
