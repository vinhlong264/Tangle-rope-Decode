using System;
using BrunoMikoski.AnimationSequencer;
using DG.Tweening;
using Shapes;
using UnityEngine;

namespace CresciveCore.Extensions
{
	[Serializable]
	public sealed class FadeShapeGroupDOTweenAction : DOTweenActionBase
	{
		[SerializeField]
		private float alpha;

		private ShapeGroup shapeGroup;

		private float previousFade;

		public override Type TargetComponentType => null;

		public override string DisplayName => null;

		public float Alpha
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected override Tweener GenerateTween_Internal(GameObject target, float duration)
		{
			return null;
		}

		public override void ResetToInitialState()
		{
		}
	}
}
