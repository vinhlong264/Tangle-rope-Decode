using System;

namespace Crescive.TwistedTangle
{
	[Serializable]
	public class RopeCollideData
	{
		public RopeEntity RopeEntity;

		public bool Colliding;

		public float CollideTimer;

		public bool Merged;

		public bool CanMerge => false;

		public RopeCollideData(RopeEntity ropeEntity, bool colliding, float collideTimer)
		{
		}

		public RopeCollideData(RopeEntity ropeEntity)
		{
		}
	}
}
