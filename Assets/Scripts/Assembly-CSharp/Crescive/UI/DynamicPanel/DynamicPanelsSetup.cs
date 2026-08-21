using System.Collections.Generic;
using UnityEngine;

namespace Crescive.UI.DynamicPanel
{
	[DefaultExecutionOrder(-100000)]
	public class DynamicPanelsSetup : MonoBehaviour
	{
		[SerializeField]
		private List<DynamicPanelChannelPair> dynamicPanelChannelPairs;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
