using System;
using DG.Tweening;
using UnityEngine;

namespace Crescive.UI
{
	public class Popover : MonoBehaviour
	{
		[SerializeField]
		private RectTransform scalePivot;

		[SerializeField]
		private bool animateShow;

		[SerializeField]
		private bool animateHide;

		private Action onHide;

		public Tween ShowTween { get; private set; }

		public Tween HideTween { get; private set; }

		private void OnEnable()
		{
		}

		public void Show(Action onHide)
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		public void HideIfShown()
		{
		}

		public void Toggle()
		{
		}
	}
}
