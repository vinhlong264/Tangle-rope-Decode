using System;
using UnityEngine.Serialization;

namespace Crescive.CreatorMode
{
	[Serializable]
	public struct RopeWidthData : ICloneable
	{
		public int RopeIndex;

		[FormerlySerializedAs("WidthScale")]
		[FormerlySerializedAs("Width")]
		public float Scale;

		public RopeWidthData(int ropeIndex, float scale)
		{
			RopeIndex = 0;
			Scale = 0f;
		}

		public object Clone()
		{
			return null;
		}
	}
}
