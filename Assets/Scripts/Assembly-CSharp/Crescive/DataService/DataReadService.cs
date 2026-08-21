using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using RSG;
using UnityEngine;

namespace Crescive.DataService
{
	public abstract class DataReadService<TData> : BaseDataReadService
	{
		[SerializeField]
		protected TData initialData;

		[SerializeField]
		protected TData actualData;

		[SerializeField]
		protected DataProvider<TData> plainDataProvider;

		[NonSerialized]
		private bool isInitialized;

		protected virtual bool IsDataReadOnly => false;

		public TData InitialData => default(TData);

		public TData Data => default(TData);

		protected virtual void OnEnable()
		{
		}

		public void SetData(TData data)
		{
		}

		public void Get(DataProviderGetCallback<TData> serviceGetCallback)
		{
		}

		public RSG.IPromise<TData> GetAsync()
		{
			return null;
		}

		public IObservable<TData> GetAsObservable()
		{
			return null;
		}

		public IObservable<TData> GetAsObservable(CancellationToken ct)
		{
			return null;
		}

		public UniTask<TData> GetAsyncUniTask()
		{
			return default(UniTask<TData>);
		}

		public UniTask<TData> GetAsyncUniTask(CancellationToken ct)
		{
			return default(UniTask<TData>);
		}

		public override void GetSync()
		{
		}

		protected abstract TData GetInitialDataCopy();

		private TData ValidateData(TData plainData)
		{
			return default(TData);
		}

		protected virtual TData PreProcessData(TData plainData)
		{
			return default(TData);
		}

		protected abstract bool IsDataValid(TData plainData);

		protected virtual void OnInitializedInternal(TData data)
		{
		}

		public void CopyInitialDataJsonToClipboard(bool prettyPrint = true)
		{
		}

		public void PasteInitialDataJsonFromClipboard()
		{
		}

		public override void ResetActualData()
		{
		}

		public void ValidateInitialDataWithElephant()
		{
		}
	}
}
