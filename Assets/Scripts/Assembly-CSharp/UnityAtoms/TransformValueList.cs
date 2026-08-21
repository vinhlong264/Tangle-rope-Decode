using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Transform", fileName = "TransformValueList")]
	[EditorIcon("atom-icon-piglet")]
	public sealed class TransformValueList : AtomValueList<Transform, TransformEvent>
	{
	}
}
