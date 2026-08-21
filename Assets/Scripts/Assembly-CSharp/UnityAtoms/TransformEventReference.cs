using System;
using UnityEngine;

namespace UnityAtoms
{
	[Serializable]
	public sealed class TransformEventReference : AtomEventReference<Transform, TransformVariable, TransformEvent, TransformVariableInstancer, TransformEventInstancer>, IGetEvent
	{
	}
}
