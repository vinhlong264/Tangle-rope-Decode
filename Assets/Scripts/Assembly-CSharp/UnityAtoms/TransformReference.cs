using System;
using UnityEngine;

namespace UnityAtoms
{
	[Serializable]
	public sealed class TransformReference : AtomReference<Transform, TransformPair, TransformConstant, TransformVariable, TransformEvent, TransformPairEvent, TransformTransformFunction, TransformVariableInstancer>, IEquatable<TransformReference>
	{
		public TransformReference()
		{
		}

		public TransformReference(Transform value)
		{
		}

		public bool Equals(TransformReference other)
		{
			return false;
		}

		protected override bool ValueEquals(Transform other)
		{
			return false;
		}
	}
}
