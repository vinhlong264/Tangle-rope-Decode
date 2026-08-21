using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Crescive.UI.Transitions
{
	public class MaskTransition : MonoBehaviour
	{
		[SerializeField]
		private Image image;

		[SerializeField]
		private float outsideToInsideDuration;

		[SerializeField]
		private Ease outsideToInsideEase;

		[SerializeField]
		private float insideToOutsideDuration;

		[SerializeField]
		private Ease insideToOutsideEase;

		public UnityEvent OnAnimateToInsideCompleted;

		public UnityEvent OnAnimateToOutsideCompleted;

		private Material material;

		private static readonly int Progress;

		private void Awake()
		{
		}

		public void AnimateToInside()
		{
		}

		public void AnimateToOutside()
		{
		}

		private Tween AnimateProgress(float progress, float duration, Ease ease = Ease.Unset)
		{
			return null;
		}
	}
}
