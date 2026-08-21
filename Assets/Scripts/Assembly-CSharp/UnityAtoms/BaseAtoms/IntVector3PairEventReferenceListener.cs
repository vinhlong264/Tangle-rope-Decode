using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
	[AddComponentMenu("Unity Atoms/Listeners/IntVector3Pair Event Reference Listener")]
	[EditorIcon("atom-icon-orange")]
	public sealed class IntVector3PairEventReferenceListener : AtomEventReferenceListener<IntVector3Pair, IntVector3PairEvent, IntVector3PairEventReference, IntVector3PairUnityEvent>
	{
	}
}
