using System.Collections.Generic;
using UnityEngine;

namespace CresciveCore.Utils
{
	[DefaultExecutionOrder(int.MinValue)]
	public class SingletonSOSetup : MonoBehaviour
	{
		[SerializeField]
		private List<BaseSingletonSO> singletons;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
