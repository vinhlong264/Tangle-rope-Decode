using DG.Tweening;
using UnityEngine;

namespace Crescive.HomeMenu
{
	public class SelectableRectTransformUpdater : MonoBehaviour
	{
		[SerializeField]
		private RectTransform rectTransform;

		[SerializeField]
		private float selectedHeight;

		[SerializeField]
		private float deselectedHeight;

		[SerializeField]
		private float duration;

		private Tween tween;

		public void OnSelected()
		{
		}

		public void OnDeselected()
		{
		}

		private void AnimateHeight(float height)
		{
		}
	}
}
