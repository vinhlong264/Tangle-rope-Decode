using UnityEngine;

namespace UnityAtoms
{
	[EditorIcon("atom-icon-cherry")]
	[CreateAssetMenu(menuName = "Unity Atoms/Events/Transform", fileName = "TransformEvent")]
	public sealed class TransformEvent : AtomEvent<Transform>
	{
	}
}
