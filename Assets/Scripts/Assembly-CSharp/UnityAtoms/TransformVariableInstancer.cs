using UnityEngine;

namespace UnityAtoms
{
	[AddComponentMenu("Unity Atoms/Variable Instancers/Transform Variable Instancer")]
	[EditorIcon("atom-icon-hotpink")]
	public class TransformVariableInstancer : AtomVariableInstancer<TransformVariable, TransformPair, Transform, TransformEvent, TransformPairEvent, TransformTransformFunction>
	{
	}
}
