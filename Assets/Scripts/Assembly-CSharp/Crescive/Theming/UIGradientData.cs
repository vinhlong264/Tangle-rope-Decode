using System;
using Coffee.UIEffects;
using UnityEngine;

namespace Crescive.Theming
{
	[Serializable]
	public class UIGradientData
	{
		public UIGradient.Direction direction;

		public float rotation;

		public float offset1;

		public Vector2 offset2;

		public Color color1;

		public Color color2;

		public Color color3;

		public Color color4;

		public void ApplyTo(UIGradient uiGradient)
		{
		}
	}
}
