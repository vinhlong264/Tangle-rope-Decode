using System;
using DG.Tweening;
using UnityEngine;

namespace Crescive.UI
{
	[Serializable]
	public class Vector3AnimationSettings : BaseAnimationSettings<Vector3>
	{
		public Vector3AnimationSettings()
		{
		}

		public Vector3AnimationSettings(Vector3 value, float duration = 0.5f, float delay = 0f, Ease ease = Ease.OutQuad, bool enabled = true)
		{
		}

		public Vector3AnimationSettings(Vector3AnimationSettings other)
		{
		}
	}
}
