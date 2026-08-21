using System;
using UnityEngine;

namespace Crescive.Leveling
{
	[Serializable]
	public struct ValueModifierData : IEquatable<ValueModifierData>
	{
		public Vector2Int levelStartEnd;

		public CalculateType calculateType;

		public float value;

		public bool hasSelfModifier;

		public CalculateType selfModCalculateType;

		public float selfModValue;

		public float GetValue(int level)
		{
			return 0f;
		}

		public bool Equals(ValueModifierData other)
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

		public static bool operator ==(ValueModifierData left, ValueModifierData right)
		{
			return false;
		}

		public static bool operator !=(ValueModifierData left, ValueModifierData right)
		{
			return false;
		}
	}
}
