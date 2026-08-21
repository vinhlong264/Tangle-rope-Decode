using System;
using System.Collections.Generic;

namespace Obi
{
	[Serializable]
	public class ObiActorCollisionData
	{
		private ObiActor actor;

		private List<ObiContactData> contactActors;

		private List<ObiContactData> ignoredActors;

		private float lastCollisionTime;

		private float resetPeriod;

		private bool hasCollidedAny;

		private ObiColliderBase lastContactedSurfaceCollider;

		private List<ObiActorCollisionData> ContactingActors => null;

		private List<ObiActorCollisionData> IgnoringActors => null;

		public ObiActor Actor => null;

		public bool IsColliding => false;

		public bool IsNotColliding => false;

		public bool HasCollidedAny => false;

		public ObiActorCollisionData(ObiActor actor, float resetPeriod)
		{
		}

		private bool IsCollisionTimeOut()
		{
			return false;
		}

		private List<ObiActorCollisionData> GetContactingActorList(bool includeSelf = false, bool includeIgnoredContacts = false)
		{
			return null;
		}

		private void GetContactingActorsRecursive(ObiActorCollisionData actorCollisionData, List<ObiActorCollisionData> contacts, bool includeIgnoredContacts = false)
		{
		}

		private void RemoveNullIgnoreActors()
		{
		}

		private void RemoveContactsContainingIgnoreActors()
		{
		}

		private bool HasIgnoredActor(ObiActorCollisionData actorData)
		{
			return false;
		}

		private ObiContactData GetIgnoredContactDataWith(ObiActorCollisionData other)
		{
			return null;
		}

		private void UpdateLastCollisionTime()
		{
		}

		public void AddOrUpdateContactActor(ObiActorCollisionData other)
		{
		}

		public void RemoveSafeContactActor(ObiActor other)
		{
		}

		public bool IsCollidingWith(ObiActor actor)
		{
			return false;
		}

		public void UpdateCollidedAny()
		{
		}

		public void RemoveNullContactActors()
		{
		}

		public void RemoveTimeOutContactActors(float resetPeriod)
		{
		}

		public void RemoveTimeOutIgnoreActors(float resetPeriod)
		{
		}

		public bool IsActorNull()
		{
			return false;
		}

		public ObiContactData GetContactDataWith(ObiActor actor)
		{
			return null;
		}

		public List<ObiActorCollisionData> GetContactingActorsRecursive(bool includeSelf, bool includeIgnoredContacts = false)
		{
			return null;
		}

		public void UpdateLastContactedSurfaceCollider(ObiColliderBase collider)
		{
		}

		public List<ObiActorCollisionData> GetContactingActors(bool includeSelf = false, bool recursive = false, bool includeIgnoredContacts = false)
		{
			return null;
		}

		public void AddIgnoreActor(ObiActorCollisionData actorData)
		{
		}

		public void RemoveIgnoreActor(ObiActorCollisionData actorData)
		{
		}
	}
}
