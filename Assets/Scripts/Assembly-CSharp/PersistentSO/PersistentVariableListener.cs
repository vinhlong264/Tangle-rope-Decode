using UnityEngine;
using UnityEngine.Events;

namespace PersistentSO
{
	public class PersistentVariableListener<T> : MonoBehaviour
	{
		[SerializeField]
		private PersistentVariable<T> variable;

		[SerializeField]
		private bool triggerOnAwake;

		[SerializeField]
		private bool triggerOnEnable;

		[SerializeField]
		private bool triggerOnStart;

		[SerializeField]
		private bool dontListenChanges;

		public UnityEvent<T> OnChanged;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		protected virtual void OnValueChanged(T value)
		{
		}

		public void TriggerOnChanged()
		{
		}
	}
}
