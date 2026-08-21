using RSG;
using UnityEngine;

namespace Crescive.DataService
{
	public abstract class DataWriteService<TData> : ScriptableObject
	{
		[SerializeField]
		protected DataWriter<TData> dataWriter;

		public IPromise<TData> Set(TData data)
		{
			return null;
		}
	}
}
