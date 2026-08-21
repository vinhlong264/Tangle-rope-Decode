using System;
using Lofelt.NiceVibrations;
using PersistentSO;
using UnityEngine;

namespace Crescive.Vibrations
{
	[CreateAssetMenu(fileName = "HapticChannel", menuName = "Crescive/Haptic/HapticChannel")]
	public class HapticChannel : PersistentVariable<HapticChannelData>
	{
		[Header("iOS")]
		public bool iosInterval;

		public float iosRequestInterval;

		[Header("Android")]
		public bool androidInterval;

		public float androidRequestInterval;

		[NonSerialized]
		private float _lastRequestTime;

		public void SetActive(bool active)
		{
		}

		public override HapticChannelData GetCopy(HapticChannelData value)
		{
			return default(HapticChannelData);
		}

		public void PlaySelection()
		{
		}

		public void PlaySuccess()
		{
		}

		public void PlayWarning()
		{
		}

		public void PlayFailure()
		{
		}

		public void PlayRigidImpact()
		{
		}

		public void PlaySoftImpact()
		{
		}

		public void PlayLightImpact()
		{
		}

		public void PlayMediumImpact()
		{
		}

		public void PlayHeavyImpact()
		{
		}

		public void PlayPreset(HapticPatterns.PresetType type)
		{
		}

		public void PlayConstant(float amplitude, float frequency, float duration)
		{
		}

		public void PlayEmphasis(float amplitude, float frequency)
		{
		}

		public void PlayClip(HapticClip clip)
		{
		}

		private void HandleHapticTrigger(Action hapticFunc)
		{
		}

		private bool CanTriggerHaptic()
		{
			return false;
		}
	}
}
