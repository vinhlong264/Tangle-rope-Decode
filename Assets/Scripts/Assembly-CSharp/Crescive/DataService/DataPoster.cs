using RSG;
using UnityEngine;

namespace Crescive.DataService
{
	public abstract class DataPoster<TData, TResult> : ScriptableObject where TData : class
	{
		public abstract IPromise<TResult> Post(TData data);
	}
}
