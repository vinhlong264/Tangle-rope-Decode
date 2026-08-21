using System;
using System.Collections.Generic;
using RSG;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.DataService
{
	public abstract class RemoteConfigCompositeDataProvider<TData> : DataProvider<TData> where TData : IMergeable<TData>
	{
		[Serializable]
		private class CompositeConfig
		{
			public List<string> Keys;
		}

		[SerializeField]
		protected StringVariable remoteCompositeConfigVariable;

		[SerializeField]
		private CresciveBaseRemoteConfigSource configSource;

		[SerializeField]
		private List<string> defaultSubKeys;

		private List<TData> GetSubDataList(List<string> subKeys)
		{
			return null;
		}

		private TData GetCompositeData()
		{
			return default(TData);
		}

		private CompositeConfig GetCompositeConfig()
		{
			return null;
		}

		public override void Get(DataProviderGetCallback<TData> getCallback)
		{
		}

		public override IPromise<TData> Get()
		{
			return null;
		}

		private void CopySubkeysJsonToClipboard(bool prettyPrint = true)
		{
		}
	}
}
