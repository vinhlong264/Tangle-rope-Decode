using System;
using System.Collections.Generic;
using Crescive.TwistedTangle;
using UnityEngine;

namespace Crescive.CreatorMode
{
	[Serializable]
	public class RopeData : ICloneable
	{
		public Vector3 Position;

		public List<RopeParticleData> Particles;

		public List<Vector3> ParticlePositions => null;

		public Vector3 StartParticlePosition => default(Vector3);

		public Vector3 EndParticlePosition => default(Vector3);

		public RopeData(RopeEntity ropeEntity)
		{
		}

		public RopeData(RopeData data)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
