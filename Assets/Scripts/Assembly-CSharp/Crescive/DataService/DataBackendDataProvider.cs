using RSG;
using UnityEngine;

namespace Crescive.DataService
{
	public abstract class DataBackendDataProvider<TData> : DataProvider<TData>, IDataBackendUser
	{
		[SerializeField]
		public string key;

		[SerializeField]
		private DataBackend dataBackend;

		public void SetBackend(DataBackend backend)
		{
		}

		public override void Get(DataProviderGetCallback<TData> getCallback)
		{
		}

		public override IPromise<TData> Get()
		{
			return null;
		}
	}
}
