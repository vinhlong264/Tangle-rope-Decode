using PersistentSO;
using RSG;
using UnityEngine;

namespace Crescive.DataService
{
	public abstract class PersistentVariableDataWriter<TData> : DataWriter<TData>
	{
		[SerializeField]
		private PersistentVariable<TData> variable;

		public override IPromise<TData> Set(TData data)
		{
			return null;
		}
	}
}
