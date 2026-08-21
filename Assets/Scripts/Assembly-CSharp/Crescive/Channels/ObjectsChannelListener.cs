using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Channels
{
	public class ObjectsChannelListener<T, TChannel> : MonoBehaviour where T : Component where TChannel : ObjectsChannel<T>
	{
		[SerializeField]
		protected TChannel objectsChannel;

		[SerializeField]
		private UnityEvent<T> OnAdded;

		[SerializeField]
		private UnityEvent<T> OnRemoved;

		[SerializeField]
		private UnityEvent<List<T>> OnAddedMultiple;

		[SerializeField]
		private UnityEvent<List<T>> OnRemovedMultiple;

		[SerializeField]
		private UnityEvent OnDataChanged;

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		private void OnAddedCallback(T obj)
		{
		}

		private void OnRemovedCallback(T obj)
		{
		}

		private void OnAddedMultipleCallback(List<T> objects)
		{
		}

		private void OnRemovedMultipleCallback(List<T> objects)
		{
		}

		private void OnDataChangedCallback()
		{
		}
	}
}
