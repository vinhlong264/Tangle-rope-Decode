using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Shapes;
using UnityEngine;

namespace CresciveCore.Extensions
{
	public static class DOTweenExtensions
	{
		public static TweenerCore<float, float, FloatOptions> DOFade(this ShapeGroup target, float endValue, float duration)
		{
			return null;
		}

		public static Sequence DOSequence(this GameObject gameObject)
		{
			return null;
		}

		public static Sequence DOSequence(this Component component)
		{
			return null;
		}

		public static TweenerCore<Vector3, Path, PathOptions> DOCurvedMove(this Transform target, Vector3 endValue, float duration, float curveStrength, float curvePlacement = 0.5f)
		{
			return null;
		}

		public static TweenerCore<Vector3, Path, PathOptions> DOLocalCurvedMove(this Transform target, Vector3 endValue, float duration, float curveStrength, float curvePlacement = 0.5f)
		{
			return null;
		}
	}
}
