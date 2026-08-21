using UnityEngine;

namespace Crescive.Channels
{
	public abstract class ObjectChannel<T> : ScriptableObject, IResettableObject where T : Object
	{
		[SerializeField]
		protected T data;

		public bool IsDataInitialized => false;

		public virtual T Data => null;

		public virtual void SetupData(T newData)
		{
		}

		public virtual void ResetData()
		{
		}
	}
}
