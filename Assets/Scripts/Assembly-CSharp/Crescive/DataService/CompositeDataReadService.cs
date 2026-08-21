using System;
using System.Collections.Generic;
using UnityEngine;

namespace Crescive.DataService
{
	public abstract class CompositeDataReadService<TData> : DataReadService<TData> where TData : class, IMergeable<TData>, ICloneable
	{
		[SerializeField]
		private List<DataSO<TData>> dataSources;

		protected override bool IsDataReadOnly => false;

		private List<TData> AllDataCloned => null;

		public void FillInitialData()
		{
		}

		public void ResetInitialData()
		{
		}
	}
}
