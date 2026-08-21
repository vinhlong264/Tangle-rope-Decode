using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Utils
{
	public class TriggerChecker : MonoBehaviour
	{
		[Serializable]
		public class ContactData
		{
			public Collider Collider;

			public float Time;

			public bool HasTimeOut(float resetPeriod)
			{
				return false;
			}

			public void ResetTime()
			{
			}

			public ContactData(Collider collider, float time)
			{
			}

			public ContactData(Collider collider)
			{
			}
		}

		[SerializeField]
		private float triggerResetPeriod;

		[SerializeField]
		private bool useFixedDeltaTime;

		public UnityEvent OnTriggerActivated;

		public UnityEvent OnTriggerDeactivated;

		[SerializeField]
		private bool isTriggering;

		private float timer;

		[SerializeField]
		private int contactCount;

		[SerializeField]
		private List<GameObject> ignoreGameObjects;

		[SerializeField]
		private List<Collider> ignoreColliders;

		[SerializeField]
		private List<ContactData> ignoredContacts;

		private float DeltaTime => 0f;

		public bool HasTriggeredAny { get; private set; }

		public bool IsTriggering => false;

		[field: SerializeField]
		public List<ContactData> Contacts { get; private set; }

		public int ContactCount => 0;

		public bool HasContacts => false;

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void UpdateAll()
		{
		}

		private void RemoveNullIgnoreGameObjects()
		{
		}

		private void RemoveNullIgnoreColliders()
		{
		}

		private void RemoveNullIgnoredContacts()
		{
		}

		private void UpdateContacts()
		{
		}

		private void UpdateIgnoredContacts()
		{
		}

		private void RemoveNullContacts()
		{
		}

		private void TryResettingByTimer()
		{
		}

		private void ActivateTrigger()
		{
		}

		private void DeactivateTrigger()
		{
		}

		private void AddContact(Collider collider)
		{
		}

		private void RemoveContact(Collider collider)
		{
		}

		private void RemoveContacts(List<Collider> colliders)
		{
		}

		private bool HasContact(Collider collider)
		{
			return false;
		}

		private void AddIgnoreContact(Collider collider)
		{
		}

		private void RemoveIgnoreContact(Collider collider)
		{
		}

		private void RemoveIgnoreContacts(List<Collider> colliders)
		{
		}

		private bool HasIgnoreContact(Collider collider)
		{
			return false;
		}

		private bool IsIgnored(Collider collider)
		{
			return false;
		}

		private void OnTriggerColliderInternal(Collider other)
		{
		}

		private void GetTriggeringCheckersRecursive(TriggerChecker checker, List<TriggerChecker> checkers, bool includeIgnoredContacts = false)
		{
		}

		private void ResetContactTime(Collider collider)
		{
		}

		private void ResetIgnoreContactTime(Collider collider)
		{
		}

		private void RemoveContainingColliderContacts(Collider collider)
		{
		}

		private void RemoveContainingGameObjectContacts(GameObject go)
		{
		}

		private List<TriggerChecker> SelectTriggerCheckersFromContacts(List<ContactData> c)
		{
			return null;
		}

		private List<TriggerChecker> GetContactingCheckerList(bool includeSelf = false, bool includeIgnoredContacts = false)
		{
			return null;
		}

		public void OnEnterTrigger(Collider other)
		{
		}

		public void OnStayTrigger(Collider other)
		{
		}

		public void OnExitTrigger(Collider other)
		{
		}

		public void AddIgnoreGameObject(GameObject go)
		{
		}

		public void AddIgnoreCollider(Collider collider)
		{
		}

		public void RemoveIgnoreGameObject(GameObject gameObject)
		{
		}

		public void RemoveIgnoreCollider(Collider collider)
		{
		}

		public List<TriggerChecker> GetContactingCheckers(bool includeSelf = false, bool recursive = false, bool includeIgnoredContacts = false)
		{
			return null;
		}

		public List<TriggerChecker> GetContactingCheckersRecursive(bool includeSelf = true, bool includeIgnoredContacts = false)
		{
			return null;
		}
	}
}
