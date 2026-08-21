using System;
using Crescive.TwistedTangle;
using UnityEngine;

namespace Crescive.CreatorMode
{
	[Serializable]
	public class ClampData : ICloneable
	{
		public Vector3 Position;

		public Quaternion Rotation;

		public ClampData(ClampEntity clampEntity)
		{
		}

		public ClampData(ClampData copy)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
