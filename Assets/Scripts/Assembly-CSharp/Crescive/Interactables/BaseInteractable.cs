using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Interactables
{
	public abstract class BaseInteractable : MonoBehaviour
	{
		[SerializeField]
		private bool oneShotCollision;

		[SerializeField]
		private float contactPeriod;

		private float lastContactTime;

		private bool _collided;

		public CollisionUnityEvent onCollisionEnter;

		public CollisionUnityEvent onCollisionStay;

		public CollisionUnityEvent onCollisionExit;

		public ColliderUnityEvent onTriggerEnter;

		public ColliderUnityEvent onTriggerStay;

		public ColliderUnityEvent onTriggerExit;

		protected virtual void OnCollisionEnter(Collision other)
		{
		}

		protected virtual void OnCollisionStay(Collision other)
		{
		}

		protected virtual void OnCollisionExit(Collision other)
		{
		}

		protected virtual void OnTriggerEnter(Collider other)
		{
		}

		protected virtual void OnTriggerStay(Collider other)
		{
		}

		protected virtual void OnTriggerExit(Collider other)
		{
		}

		protected abstract bool ValidateActor(GameObject g);

		private bool CheckIfActorCanCollide(GameObject g)
		{
			return false;
		}

		private void PerformOnCollidedEnter(Collision col)
		{
		}

		private void PerformOnCollidedStay(Collision col)
		{
		}

		private void PerformOnCollidedExit(Collision col)
		{
		}

		private void PerformOnTriggeredEnter(Collider col)
		{
		}

		private void PerformOnTriggeredStay(Collider col)
		{
		}

		private void PerformOnTriggeredExit(Collider col)
		{
		}

		protected virtual void OnCollidedEnter(Collision col)
		{
		}

		protected virtual void OnCollidedStay(Collision col)
		{
		}

		protected virtual void OnCollidedExit(Collision col)
		{
		}

		protected virtual void OnTriggeredEnter(Collider other)
		{
		}

		protected virtual void OnTriggeredStay(Collider other)
		{
		}

		protected virtual void OnTriggeredExit(Collider other)
		{
		}

		public void SetContactPeriod(float period)
		{
		}
	}
}
