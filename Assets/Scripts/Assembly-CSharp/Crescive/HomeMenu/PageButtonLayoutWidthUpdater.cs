using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.HomeMenu
{
	public class PageButtonLayoutWidthUpdater : MonoBehaviour
	{
		[SerializeField]
		private LayoutElement layoutElement;

		[SerializeField]
		private float selectedWidth;

		[SerializeField]
		private float animDuration;

		private Tween animTween;

		public void OnSelected()
		{
		}

		public void OnDeselected()
		{
		}

		private void AnimateWidth(float width)
		{
		}
	}
}
