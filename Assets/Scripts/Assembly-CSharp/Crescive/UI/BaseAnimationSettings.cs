using System;
using BrunoMikoski.AnimationSequencer;
using DG.Tweening;

namespace Crescive.UI
{
	[Serializable]
	public class BaseAnimationSettings<T>
	{
		public T startValue;

		public float duration;

		public float delay;

		public CustomEase ease;

		public bool enabled;

		public BaseAnimationSettings()
		{
		}

		public BaseAnimationSettings(T startValue, float duration = 0.5f, float delay = 0f, Ease ease = Ease.OutQuad, bool enabled = true)
		{
		}
	}
}
