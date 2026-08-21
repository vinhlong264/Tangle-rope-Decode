using System;
using UnityEngine;

namespace Easings
{
	[Serializable]
	public class Easing
	{
		public enum EasingType
		{
			Curve = 0,
			Function = 1
		}

		public EasingType Type;

		public AnimationCurve Curve;

		public EasingFunction.Ease Function;

		private const float NumericalGradientDeltaT = 0.01f;

		private EasingFunction.Function _easingFunctionImpl;

		private EasingFunction.Function _easingFunctionDerivativeImpl;

		private EasingFunction.Ease _cachedFunction;

		private EasingFunction.Function EasingFunctionImpl => null;

		private EasingFunction.Function EasingFunctionDerivativeImpl => null;

		public Easing()
		{
		}

		public Easing(AnimationCurve curve)
		{
		}

		public Easing(EasingFunction.Ease function)
		{
		}

		public static implicit operator Func<float, float, float, float>(Easing self)
		{
			return null;
		}

		public static implicit operator Easing(EasingFunction.Ease func)
		{
			return null;
		}

		public static implicit operator Easing(AnimationCurve curve)
		{
			return null;
		}

		public float Eval(float t)
		{
			return 0f;
		}

		public float Eval(float a, float b, float t)
		{
			return 0f;
		}

		public float EvalGradient(float a, float b, float t)
		{
			return 0f;
		}
	}
}
