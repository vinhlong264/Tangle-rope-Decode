using System;

namespace UnityAtoms
{
	[Serializable]
	public sealed class TransformPairEventReference : AtomEventReference<TransformPair, TransformVariable, TransformPairEvent, TransformVariableInstancer, TransformPairEventInstancer>, IGetEvent
	{
	}
}
