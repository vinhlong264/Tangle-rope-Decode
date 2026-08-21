using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu(menuName = "Unity Atoms/Variables/Transform", fileName = "TransformVariable")]
	[EditorIcon("atom-icon-lush")]
	public sealed class TransformVariable : AtomVariable<Transform, TransformPair, TransformEvent, TransformPairEvent, TransformTransformFunction>
	{
		protected override bool ValueEquals(Transform other)
		{
			return false;
		}
	}
}
