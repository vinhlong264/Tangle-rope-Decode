using System;
using DG.Tweening;

namespace Crescive.UI
{
	[Serializable]
	public class FloatAnimationSettings : BaseAnimationSettings<float>
	{
		public FloatAnimationSettings()
		{
		}

		public FloatAnimationSettings(float value, float duration = 0.5f, float delay = 0f, Ease ease = Ease.OutQuad, bool enabled = true)
		{
		}

		public FloatAnimationSettings(FloatAnimationSettings other)
		{
		}
	}
}
