using PersistentSO;
using RSG;
using UnityEngine;

namespace Crescive.DataService
{
	public abstract class PersistentVariableDataProvider<TData> : DataProvider<TData>
	{
		[SerializeField]
		private PersistentVariable<TData> variable;

		public override void Get(DataProviderGetCallback<TData> getCallback)
		{
		}

		public override IPromise<TData> Get()
		{
			return null;
		}
	}
}
