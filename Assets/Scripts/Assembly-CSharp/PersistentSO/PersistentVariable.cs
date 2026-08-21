using System;
using UnityEngine;
using UnityEngine.Events;

namespace PersistentSO
{
	public abstract class PersistentVariable<T> : BasePersistentVariable
	{
		[SerializeField]
		private Guid guid;

		private bool guidInitialized;

		[SerializeField]
		private bool setSessionStartValue;

		[SerializeField]
		private T initialValue;

		[SerializeField]
		private T value;

		[SerializeField]
		private bool isDirty;

		public UnityEvent<T> OnChanged;

		public UnityEvent<T, T> OnChangedHistory;

		[NonSerialized]
		private T sessionStartValue;

		public override Guid Guid => default(Guid);

		public override string SaveKey => null;

		public T InitialValue => default(T);

		public T Value
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public T SessionStartValue => default(T);

		public override object InitialValueObject => null;

		public override object ValueObject => null;

		public override object SessionStartValueObject => null;

		private void OnVariableValueChanged()
		{
		}

		private void OnValidate()
		{
		}

		private void OnEnable()
		{
		}

		public override string ToJson()
		{
			return null;
		}

		public override object FromJson(string json)
		{
			return null;
		}

		public override void SetFromJson(string json)
		{
		}

		private void Setup()
		{
		}

		private void TriggerChangedEvents(T previousValue)
		{
		}

		public void SetInitialValue(T val)
		{
		}

		public sealed override void Reset()
		{
		}

		public abstract T GetCopy(T value);

		public static implicit operator T(PersistentVariable<T> variable)
		{
			return default(T);
		}
	}
}
