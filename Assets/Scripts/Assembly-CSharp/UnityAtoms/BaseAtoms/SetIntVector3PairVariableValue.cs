using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
	[CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/IntVector3Pair", fileName = "SetIntVector3PairVariableValue")]
	[EditorIcon("atom-icon-purple")]
	public sealed class SetIntVector3PairVariableValue : SetVariableValue<IntVector3Pair, IntVector3PairPair, IntVector3PairVariable, IntVector3PairConstant, IntVector3PairReference, IntVector3PairEvent, IntVector3PairPairEvent, IntVector3PairIntVector3PairFunction, IntVector3PairVariableInstancer>
	{
	}
}
