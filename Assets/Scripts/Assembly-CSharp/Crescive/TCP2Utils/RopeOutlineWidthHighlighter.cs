using System.Collections.Generic;
using Crescive.TwistedTangle;
using DG.Tweening;
using UnityEngine;

namespace Crescive.TCP2Utils
{
	public class RopeOutlineWidthHighlighter : MonoBehaviour
	{
		[SerializeField]
		private RopeEntity ropeEntity;

		[SerializeField]
		private float normalOutlineWidth;

		[SerializeField]
		private float highlightedOutlineWidth;

		[SerializeField]
		private float highlightDuration;

		private List<Tween> highlightTweens;

		private void Awake()
		{
		}

		public void AnimateHighlight()
		{
		}

		private void AnimateMaterial(GameObject target, Material material)
		{
		}

		private void ResetMaterial(Material material)
		{
		}

		public void StopHighlighting()
		{
		}

		public void ToggleHighlight(bool state)
		{
		}
	}
}
