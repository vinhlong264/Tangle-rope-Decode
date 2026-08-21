using System;
using DG.Tweening;

namespace Crescive.UI
{
	[Serializable]
	public class VoidAnimationSettings : BaseAnimationSettings<object>
	{
		public VoidAnimationSettings()
		{
		}

		public VoidAnimationSettings(float duration = 0f, float delay = 0f, Ease ease = Ease.OutQuad, bool enabled = true)
		{
		}

		public VoidAnimationSettings(VoidAnimationSettings other)
		{
		}
	}
}
