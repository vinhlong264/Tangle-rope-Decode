using Crescive.HelperTypes;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Audio
{
	public class AudioChannelListener : MonoBehaviour
	{
		[SerializeField]
		private AudioChannel channel;

		[SerializeField]
		private AutoTriggerMethod autoTriggerMethod;

		public UnityEvent OnActive;

		public UnityEvent OnInactive;

		public UnityEvent<bool> OnActiveChanged;

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

		private void OnDataChanged(AudioChannelData data)
		{
		}

		private void TriggerEvents()
		{
		}
	}
}
