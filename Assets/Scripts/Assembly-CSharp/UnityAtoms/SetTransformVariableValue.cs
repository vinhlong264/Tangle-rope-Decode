using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Transform", fileName = "SetTransformVariableValue")]
	[EditorIcon("atom-icon-purple")]
	public sealed class SetTransformVariableValue : SetVariableValue<Transform, TransformPair, TransformVariable, TransformConstant, TransformReference, TransformEvent, TransformPairEvent, TransformTransformFunction, TransformVariableInstancer>
	{
	}
}
