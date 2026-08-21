using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace PersistentSO
{
	public abstract class BasePersistentVariable : ScriptableObject, IPersistentVariable
	{
		public DataGroups DataGroup;

		public string ReadableSaveKey;

		public UnityEvent<object> OnChangedObject;

		public UnityEvent<object, object> OnChangedObjectHistory;

		public abstract Guid Guid { get; }

		public abstract string SaveKey { get; }

		public abstract object InitialValueObject { get; }

		public abstract object ValueObject { get; }

		public abstract object SessionStartValueObject { get; }

		public static event Action OnSave
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action OnLoad
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action OnReset
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public abstract void Reset();

		public abstract string ToJson();

		public abstract object FromJson(string json);

		public abstract void SetFromJson(string json);

		protected void TriggerSaveEvent()
		{
		}

		protected void TriggerLoadEvent()
		{
		}

		protected void TriggerResetEvent()
		{
		}

		protected void ClearStaticEvents()
		{
		}
	}
}
