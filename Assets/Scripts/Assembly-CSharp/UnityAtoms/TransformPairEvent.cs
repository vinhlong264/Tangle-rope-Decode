using UnityEngine;

namespace UnityAtoms
{
	[EditorIcon("atom-icon-cherry")]
	[CreateAssetMenu(menuName = "Unity Atoms/Events/TransformPair", fileName = "TransformPairEvent")]
	public sealed class TransformPairEvent : AtomEvent<TransformPair>
	{
	}
}
