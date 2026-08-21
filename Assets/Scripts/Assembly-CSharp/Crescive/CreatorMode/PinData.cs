using System;
using Crescive.TwistedTangle;
using UnityEngine;

namespace Crescive.CreatorMode
{
	[Serializable]
	public class PinData : ICloneable
	{
		public Vector3 Position;

		public bool IsLocked;

		public PinData(PinEntity pinEntity)
		{
		}

		public PinData(PinData data)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
