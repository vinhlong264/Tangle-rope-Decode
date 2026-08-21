using System;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Leveling
{
	[Serializable]
	public struct ReferencedValueModifierData : IEquatable<ReferencedValueModifierData>
	{
		public Vector2Int levelStartEnd;

		public CalculateType calculateType;

		public FloatReference reference;

		public float Value => 0f;

		public bool Equals(ReferencedValueModifierData other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(ReferencedValueModifierData left, ReferencedValueModifierData right)
		{
			return false;
		}

		public static bool operator !=(ReferencedValueModifierData left, ReferencedValueModifierData right)
		{
			return false;
		}
	}
}
