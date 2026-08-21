using RSG;

namespace Crescive.DataService
{
	public abstract class JsonDataProvider<TData> : DataProvider<TData>
	{
		protected abstract void GetJson(JsonCallback jsonCallback);

		protected abstract IPromise<string> GetJsonAsync();

		private TData ParseJson(string json)
		{
			return default(TData);
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
