using DG.Tweening;
using UnityEngine;

namespace Crescive.TCP2Utils
{
	public class TCP2OutlineWidthHighlighter : MonoBehaviour
	{
		[SerializeField]
		private Renderer renderer;

		[SerializeField]
		private float normalOutlineWidth;

		[SerializeField]
		private float highlightedOutlineWidth;

		[SerializeField]
		private float highlightDuration;

		private Tween highlightTween;

		public void AnimateHighlight()
		{
		}

		public void StopHighlighting()
		{
		}
	}
}
