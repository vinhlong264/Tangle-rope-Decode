using System;
using UnityEngine;

namespace PersistentSO
{
	[Serializable]
	public struct Guid : IEquatable<Guid>
	{
		[SerializeField]
		[HideInInspector]
		private uint m_Value0;

		[HideInInspector]
		[SerializeField]
		private uint m_Value1;

		[SerializeField]
		[HideInInspector]
		private uint m_Value2;

		[HideInInspector]
		[SerializeField]
		private uint m_Value3;

		public uint Value0 => 0u;

		public uint Value1 => 0u;

		public uint Value2 => 0u;

		public uint Value3 => 0u;

		public Guid(uint val0, uint val1, uint val2, uint val3)
		{
			m_Value0 = 0u;
			m_Value1 = 0u;
			m_Value2 = 0u;
			m_Value3 = 0u;
		}

		public Guid(string hexString)
		{
			m_Value0 = 0u;
			m_Value1 = 0u;
			m_Value2 = 0u;
			m_Value3 = 0u;
		}

		public static bool operator ==(Guid x, Guid y)
		{
			return false;
		}

		public static bool operator !=(Guid x, Guid y)
		{
			return false;
		}

		public bool Equals(Guid other)
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

		public string ToHexString()
		{
			return null;
		}

		public static void TryParse(string hexString, out Guid guid)
		{
			guid = default(Guid);
		}
	}
}
