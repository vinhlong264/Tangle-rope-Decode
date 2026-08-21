using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
	[EditorIcon("atom-icon-piglet")]
	[CreateAssetMenu(menuName = "Unity Atoms/Value Lists/IntVector3Pair", fileName = "IntVector3PairValueList")]
	public sealed class IntVector3PairValueList : AtomValueList<IntVector3Pair, IntVector3PairEvent>
	{
	}
}
