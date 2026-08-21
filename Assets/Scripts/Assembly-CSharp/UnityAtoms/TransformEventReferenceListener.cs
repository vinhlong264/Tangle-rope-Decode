using UnityEngine;

namespace UnityAtoms
{
	[AddComponentMenu("Unity Atoms/Listeners/Transform Event Reference Listener")]
	[EditorIcon("atom-icon-orange")]
	public sealed class TransformEventReferenceListener : AtomEventReferenceListener<Transform, TransformEvent, TransformEventReference, TransformUnityEvent>
	{
	}
}
