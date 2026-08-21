using DG.Tweening;
using UnityEngine;

namespace Crescive.TwistedTangle.SpecialEditor.UI
{
	public class TabHandler : MonoBehaviour
	{
		[SerializeField]
		private RectTransform tabRect;

		[SerializeField]
		private float tabSelectedTopValue;

		[SerializeField]
		private float tabSelectionSwitchDuration;

		[SerializeField]
		private Ease tabSelectionSwitchEase;

		private Tweener tabTweener;

		public void SetTabSelected()
		{
		}

		public void SetTabUnselected()
		{
		}
	}
}
