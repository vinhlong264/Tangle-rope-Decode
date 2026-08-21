using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
	[CreateAssetMenu(menuName = "Unity Atoms/Variables/IntVector3Pair", fileName = "IntVector3PairVariable")]
	[EditorIcon("atom-icon-lush")]
	public sealed class IntVector3PairVariable : AtomVariable<IntVector3Pair, IntVector3PairPair, IntVector3PairEvent, IntVector3PairPairEvent, IntVector3PairIntVector3PairFunction>
	{
		protected override bool ValueEquals(IntVector3Pair other)
		{
			return false;
		}
	}
}
