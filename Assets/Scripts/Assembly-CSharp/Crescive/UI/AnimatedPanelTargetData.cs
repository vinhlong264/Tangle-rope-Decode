using UnityEngine;

namespace Crescive.UI
{
	public class AnimatedPanelTargetData<T>
	{
		public T StartValue { get; }

		public T EndValue { get; }

		public CanvasGroup CanvasGroup { get; }

		public RectTransform RectTransform { get; }

		public AnimatedPanelTargetData(T startValue, T endValue)
		{
		}

		public AnimatedPanelTargetData(CanvasGroup canvasGroup, T startValue, T endValue)
		{
		}

		public AnimatedPanelTargetData(RectTransform rectTransform, T startValue, T endValue)
		{
		}
	}
}
