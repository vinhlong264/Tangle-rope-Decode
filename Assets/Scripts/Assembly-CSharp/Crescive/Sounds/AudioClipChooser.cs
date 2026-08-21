using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Sounds
{
	public class AudioClipChooser : MonoBehaviour
	{
		[SerializeField]
		private AudioClip[] _clips;

		public UnityEvent<AudioClip> OnChooseClip;

		public void TriggerChooseRandomEvent()
		{
		}

		public void TriggerChooseByIndexEvent(int index)
		{
		}

		private void TriggerAudioClipEvent(AudioClip clip)
		{
		}
	}
}
