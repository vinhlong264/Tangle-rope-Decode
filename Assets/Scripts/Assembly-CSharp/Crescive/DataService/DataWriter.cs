using RSG;
using UnityEngine;

namespace Crescive.DataService
{
	public abstract class DataWriter<TData> : ScriptableObject
	{
		public abstract IPromise<TData> Set(TData data);
	}
}
