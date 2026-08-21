using UnityEngine;

namespace Crescive.DataService
{
	public abstract class RemoteConfigReferenceKeyDataProvider<TData> : RemoteConfigDataProvider<TData>
	{
		[SerializeField]
		private CresciveBaseRemoteConfigSource configSource;

		protected override string Value => null;
	}
}
