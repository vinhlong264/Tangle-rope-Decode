using System;
using DG.Tweening;
using UnityEngine;

namespace Crescive.UI
{
	[Serializable]
	public class Vector2AnimationSettings : BaseAnimationSettings<Vector2>
	{
		public Vector2AnimationSettings()
		{
		}

		public Vector2AnimationSettings(Vector2 value, float duration = 0.5f, float delay = 0f, Ease ease = Ease.OutQuad, bool enabled = true)
		{
		}

		public Vector2AnimationSettings(Vector2AnimationSettings other)
		{
		}
	}
}
