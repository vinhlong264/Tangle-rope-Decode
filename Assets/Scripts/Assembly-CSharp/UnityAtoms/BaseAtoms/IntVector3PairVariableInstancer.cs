using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
	[AddComponentMenu("Unity Atoms/Variable Instancers/IntVector3Pair Variable Instancer")]
	[EditorIcon("atom-icon-hotpink")]
	public class IntVector3PairVariableInstancer : AtomVariableInstancer<IntVector3PairVariable, IntVector3PairPair, IntVector3Pair, IntVector3PairEvent, IntVector3PairPairEvent, IntVector3PairIntVector3PairFunction>
	{
	}
}
