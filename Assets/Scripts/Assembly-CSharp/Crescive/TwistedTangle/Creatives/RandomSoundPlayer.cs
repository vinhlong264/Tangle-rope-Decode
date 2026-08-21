using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.TwistedTangle.Creatives
{
	public class RandomSoundPlayer : MonoBehaviour
	{
		[SerializeField]
		private AudioSource audioSource;

		[SerializeField]
		private AudioClip[] audioClips;

		[SerializeField]
		private VoidEvent playRandomSoundEvent;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void PlayRandomSound()
		{
		}
	}
}
