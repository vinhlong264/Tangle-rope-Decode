using CresciveCore;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.HomeMenu
{
	[DefaultExecutionOrder(1)]
	public class HomeMenuActiveCallback : MonoBehaviour
	{
		[SerializeField]
		private LoaderChannel loaderChannel;

		[SerializeField]
		private UnityEvent OnHomeMenuActive;

		[SerializeField]
		private UnityEvent OnHomeMenuInactive;

		private void Awake()
		{
		}

		private void InvokeEvents()
		{
		}
	}
}
