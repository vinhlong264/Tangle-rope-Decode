using System;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	[Serializable]
	public struct RopeParticleData
	{
		public Vector3 position;

		public RopeParticleData(Vector3 position)
		{
			this.position = default(Vector3);
		}
	}
}
