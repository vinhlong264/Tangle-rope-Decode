using System;
using Obi;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	[Serializable]
	public class RopeRaycastData
	{
		public RopeEntity Rope;

		public ObiStructuralElement Element;

		public Vector3 Particle1Position => default(Vector3);

		public Vector3 Particle2Position => default(Vector3);

		public Vector3 HitPoint => default(Vector3);
	}
}
