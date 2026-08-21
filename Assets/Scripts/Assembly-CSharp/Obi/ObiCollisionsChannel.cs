using System.Collections.Generic;
using UnityEngine;

namespace Obi
{
	[CreateAssetMenu(fileName = "ObiCollisionsChannel", menuName = "Obi/Collisions/Obi Collisions Channel")]
	public class ObiCollisionsChannel : ScriptableObject
	{
		[SerializeField]
		private List<int> collideableCategories;

		[SerializeField]
		private float resetPeriod;

		[SerializeField]
		private float minContactNormalAbsDot;

		[SerializeField]
		private float maxContactDistance;

		[SerializeField]
		private bool debug;

		private List<ObiActorCollisionData> allActorContacts;

		private List<ObiActor> ignoredActors;

		private List<int> categories => null;

		private void AddOrUpdateActorsCollisionData(ObiActor actorA, ObiActor actorB)
		{
		}

		private void UpdateActorContacts(ObiActor actorA, ObiActor actorB)
		{
		}

		public ObiActorCollisionData GetOrAddActorCollisionData(ObiActor actor)
		{
			return null;
		}

		private void AddActorFromContactWithSurfaceCollider(ObiSolver solver, Oni.Contact contact)
		{
		}

		private bool ContainsCollideableFilter(int filter)
		{
			return false;
		}

		private void AddActorsFromContact(ObiSolver solver, Oni.Contact contact)
		{
		}

		private ObiActor GetActorFromContact(ObiSolver obiSolver, int contactBody)
		{
			return null;
		}

		private void ClearNullData()
		{
		}

		private void ClearTimeOutContactCollisions()
		{
		}

		private void ClearTimeOutIgnoreContacts()
		{
		}

		private void UpdateIsColliding()
		{
		}

		public void UpdateContacts(ObiSolver solver, ObiSolver.ObiCollisionEventArgs args)
		{
		}

		public void UpdateContactsWithSurfaceCollider(ObiSolver solver, ObiSolver.ObiCollisionEventArgs args)
		{
		}

		public void UpdateAllData()
		{
		}

		public void ClearData()
		{
		}

		public bool IsActorColliding(ObiActor actor)
		{
			return false;
		}

		public bool HasActorCollidedAny(ObiActor actor)
		{
			return false;
		}

		public bool IsActorCollidingWith(ObiActor actor, ObiActor otherActor)
		{
			return false;
		}

		public ObiActorCollisionData GetActorCollisionData(ObiActor actor)
		{
			return null;
		}

		public void IgnoreActor(ObiActor actor)
		{
		}

		public void UnignoreActor(ObiActor actor)
		{
		}

		public bool IsActorIgnored(ObiActor actor)
		{
			return false;
		}
	}
}
