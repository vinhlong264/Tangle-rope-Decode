using UnityEngine;

namespace UnityAtoms
{
	[EditorIcon("atom-icon-orange")]
	[AddComponentMenu("Unity Atoms/Listeners/TransformPair Event Reference Listener")]
	public sealed class TransformPairEventReferenceListener : AtomEventReferenceListener<TransformPair, TransformPairEvent, TransformPairEventReference, TransformPairUnityEvent>
	{
	}
}
