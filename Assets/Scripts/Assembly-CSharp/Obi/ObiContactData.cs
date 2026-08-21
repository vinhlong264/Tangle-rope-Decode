using System;

namespace Obi
{
	[Serializable]
	public class ObiContactData
	{
		public ObiActorCollisionData ContactActorData;

		private float lastCollisionTime;

		public float LastCollisionTime => 0f;

		public ObiContactData(ObiActorCollisionData contactActorData)
		{
		}

		public bool HasTimeOut(float resetPeriod)
		{
			return false;
		}

		public bool IsActorEqual(ObiActor actor)
		{
			return false;
		}

		public bool IsActorCollisionDataEqual(ObiActorCollisionData actorCollisionData)
		{
			return false;
		}

		public bool IsContactActorNull()
		{
			return false;
		}

		public void UpdateLastCollisionTime()
		{
		}
	}
}
