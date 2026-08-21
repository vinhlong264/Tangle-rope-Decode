using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Pooling
{
	public class PoolersController : MonoBehaviour
	{
		[SerializeField]
		private List<ObjectPoolerBehaviour> poolers;

		[SerializeField]
		private bool autoFindInChildren;

		private void Awake()
		{
		}

		public void DespawnAll()
		{
		}
	}
}
