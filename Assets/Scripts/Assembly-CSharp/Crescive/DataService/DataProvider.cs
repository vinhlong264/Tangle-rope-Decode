using RSG;
using UnityEngine;

namespace Crescive.DataService
{
	public abstract class DataProvider<TData> : ScriptableObject
	{
		public abstract void Get(DataProviderGetCallback<TData> getCallback);

		public abstract IPromise<TData> Get();
	}
}
