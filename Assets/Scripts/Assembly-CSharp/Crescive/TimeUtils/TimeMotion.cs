using DG.Tweening;
using UnityEngine;

namespace Crescive.TimeUtils
{
	public class TimeMotion : MonoBehaviour
	{
		[SerializeField]
		private TimeScaleSetter timeScaleSetter;

		[SerializeField]
		private float slowMotionScale;

		[SerializeField]
		private float slowMotionDuration;

		[SerializeField]
		private Ease slowMotionEase;

		[SerializeField]
		private float fastMotionScale;

		[SerializeField]
		private float fastMotionDuration;

		[SerializeField]
		private Ease fastMotionEase;

		private Tween tween;

		public void DoSlowMotion(bool rewindBack = true)
		{
		}

		public void DoFastMotion(bool rewindBack = true)
		{
		}

		public void DoResetMotion(float duration)
		{
		}

		private Tween DoTimeMotion(float targetScale, float duration, bool rewindBack = true, Ease ease = Ease.Unset)
		{
			return null;
		}
	}
}
