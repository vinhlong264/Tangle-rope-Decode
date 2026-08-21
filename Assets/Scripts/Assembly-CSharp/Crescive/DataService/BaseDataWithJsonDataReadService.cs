using System.Collections.Generic;
using UnityAtoms;
using UnityEngine;

namespace Crescive.DataService
{
	public abstract class BaseDataWithJsonDataReadService<TData> : DataReadService<TData> where TData : IDataWithJson
	{
		[SerializeField]
		[Header("Data With Json")]
		private List<AtomBaseVariable> variables;

		protected override void OnInitializedInternal(TData data)
		{
		}
	}
}
