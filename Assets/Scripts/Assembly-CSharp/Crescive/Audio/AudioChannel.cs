using PersistentSO;
using UnityEngine;

namespace Crescive.Audio
{
	[CreateAssetMenu(fileName = "AudioChannel", menuName = "Crescive/Audio/AudioChannel")]
	public class AudioChannel : PersistentVariable<AudioChannelData>
	{
		public void SetActive(bool active)
		{
		}

		public override AudioChannelData GetCopy(AudioChannelData value)
		{
			return default(AudioChannelData);
		}

		public void UpdateSoundVolume(float volume)
		{
		}
	}
}
