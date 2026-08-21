using Crescive.HelperTypes;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Vibrations
{
	public class HapticChannelListener : MonoBehaviour
	{
		[SerializeField]
		private HapticChannel channel;

		[SerializeField]
		private AutoTriggerMethod autoTriggerMethod;

		public UnityEvent OnHapticsActive;

		public UnityEvent OnHapticsInactive;

		public UnityEvent<bool> OnHapticsActiveChanged;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDataChanged(HapticChannelData data)
		{
		}

		private void TriggerEvents()
		{
		}
	}
}
