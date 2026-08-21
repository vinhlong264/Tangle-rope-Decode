using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Channels
{
	public abstract class ObjectsChannel<T> : ScriptableObject, IResettableObject where T : Object
	{
		[SerializeField]
		protected List<T> objects;

		public UnityEvent<T> OnAdded;

		public UnityEvent<T> OnRemoved;

		public UnityEvent<List<T>> OnAddedMultiple;

		public UnityEvent<List<T>> OnRemovedMultiple;

		public UnityEvent OnReset;

		public UnityEvent OnDataChanged;

		public virtual IReadOnlyList<T> Objects => null;

		public virtual void ResetData()
		{
		}

		public virtual void Add(T obj)
		{
		}

		public virtual bool TryAdd(T obj)
		{
			return false;
		}

		public virtual void Remove(T obj)
		{
		}

		public virtual bool TryRemove(T obj)
		{
			return false;
		}

		public virtual void AddMultiple(List<T> objectsToAdd)
		{
		}

		public virtual void RemoveMultiple(List<T> objectsToRemove)
		{
		}

		public virtual void SetupData(List<T> data)
		{
		}
	}
}
