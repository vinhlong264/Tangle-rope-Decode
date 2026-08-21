using System.Threading;
using Crescive.Levels;
using UnityEngine;

namespace Crescive.OnlineLevels
{
	public class OnlineLevelsToLocalLevelsSync : MonoBehaviour
	{
		[SerializeField]
		private string baseUrl;

		[SerializeField]
		private OnlineLevelsDataService service;

		[SerializeField]
		private LevelFunnelData funnelData;

		private CancellationToken DestroyCancellationToken => default(CancellationToken);

		public void DownloadAndSyncLevels()
		{
		}
	}
}
