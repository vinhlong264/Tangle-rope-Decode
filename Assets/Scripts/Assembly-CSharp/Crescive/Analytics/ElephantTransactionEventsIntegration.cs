using Crescive.ResourceSystem;
using CresciveCore;
using UnityEngine;

namespace Crescive.Analytics
{
	public class ElephantTransactionEventsIntegration : MonoBehaviour
	{
		[SerializeField]
		private LevelSystem levelSystem;

		[SerializeField]
		private ResourceChannel resource;

		private int LevelNumber => 0;

		private long RemainingResource => 0L;

		private string ResourceType => null;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void SendEearnTransactionEvent(ResourceValueEventArgs args)
		{
		}

		public void SendSpendTransactionEvent(ResourceValueEventArgs args)
		{
		}
	}
}
