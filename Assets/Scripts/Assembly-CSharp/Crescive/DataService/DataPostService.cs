using RSG;
using UnityEngine;

namespace Crescive.DataService
{
	public abstract class DataPostService<TData, TResult> : ScriptableObject where TData : class
	{
		[SerializeField]
		private DataPoster<TData, TResult> dataPoster;

		public IPromise<TResult> Post()
		{
			return null;
		}

		public IPromise<TResult> Post(TData data)
		{
			return null;
		}
	}
}
