using RSG;
using UnityEngine;

namespace Crescive.DataService
{
	public abstract class DataBackendDataWriter<TData> : DataWriter<TData>, IDataBackendUser
	{
		[SerializeField]
		public string key;

		[SerializeField]
		private DataBackend dataBackend;

		public void SetBackend(DataBackend backend)
		{
		}

		public override IPromise<TData> Set(TData data)
		{
			return null;
		}
	}
}
