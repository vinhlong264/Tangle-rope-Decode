using System;

namespace UnityAtoms.BaseAtoms
{
	[Serializable]
	public sealed class IntVector3PairReference : AtomReference<IntVector3Pair, IntVector3PairPair, IntVector3PairConstant, IntVector3PairVariable, IntVector3PairEvent, IntVector3PairPairEvent, IntVector3PairIntVector3PairFunction, IntVector3PairVariableInstancer>, IEquatable<IntVector3PairReference>
	{
		public IntVector3PairReference()
		{
		}

		public IntVector3PairReference(IntVector3Pair value)
		{
		}

		public bool Equals(IntVector3PairReference other)
		{
			return false;
		}

		protected override bool ValueEquals(IntVector3Pair other)
		{
			return false;
		}
	}
}
