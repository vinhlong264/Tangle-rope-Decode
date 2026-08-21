using Crescive.HelperTypes;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Economics
{
	public class LevelCoinProviderDataListener : MonoBehaviour
	{
		[SerializeField]
		private LevelCoinProviderData levelCoinProviderData;

		[SerializeField]
		private AutoTriggerMethod autoTriggerMethod;

		public UnityEvent<float> OnCoinChanged;

		public UnityEvent<int> OnCoinChangedInt;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		public void RaiseCoinEvents()
		{
		}
	}
}
