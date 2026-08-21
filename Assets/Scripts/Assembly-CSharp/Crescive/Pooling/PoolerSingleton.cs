using System.Collections.Generic;
using CresciveCore.Utils;
using UnityEngine;

namespace Crescive.Pooling
{
	[DefaultExecutionOrder(-100000000)]
	public class PoolerSingleton : Singleton<PoolerSingleton>
	{
		[SerializeField]
		private List<ObjectPoolerBehaviour> poolers;

		protected override void OnInstanceCreated()
		{
		}

		public void DespawnAll()
		{
		}
	}
}
