using RSG;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.DataService
{
	public abstract class RemoteConfigDataProvider<TData> : JsonDataProvider<TData>
	{
		[SerializeField]
		protected StringVariable remoteConfigStringVariable;

		[SerializeField]
		private bool useDebugValue;

		[SerializeField]
		private string debugValue;

		public string Key => null;

		protected virtual string Value => null;

		protected override void GetJson(JsonCallback jsonCallback)
		{
		}

		protected override IPromise<string> GetJsonAsync()
		{
			return null;
		}
	}
}
