using RSG;
using UnityEngine;

namespace Crescive.DataService
{
	public abstract class DataBackendDataPoster<TData, TResult> : DataPoster<TData, TResult>, IDataBackendUser where TData : class
	{
		[SerializeField]
		public string key;

		[SerializeField]
		private DataBackend dataBackend;

		public void SetBackend(DataBackend backend)
		{
		}

		public override IPromise<TResult> Post(TData data)
		{
			return null;
		}
	}
}
