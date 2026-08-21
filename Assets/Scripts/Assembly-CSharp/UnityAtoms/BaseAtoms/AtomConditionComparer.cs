using UnityEngine;
using UnityEngine.Events;

namespace UnityAtoms.BaseAtoms
{
	public class AtomConditionComparer : MonoBehaviour
	{
		[SerializeField]
		private AtomCondition condition;

		[SerializeField]
		private bool triggerOnAwake;

		[SerializeField]
		private bool triggerOnEnable;

		[SerializeField]
		private bool triggerOnStart;

		public UnityEvent<bool> OnCompare;

		public UnityEvent OnEqual;

		public UnityEvent OnNotEqual;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		public void TriggerEvent()
		{
		}
	}
}
