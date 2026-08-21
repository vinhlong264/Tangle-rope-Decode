using System.Collections.Generic;
using UnityEngine;

namespace Crescive.TransformUtils
{
	public class RectTransformFlipper : MonoBehaviour
	{
		public enum Axis
		{
			Horizontal = 0,
			Vertical = 1,
			Both = 2
		}

		[SerializeField]
		private RectTransform pivot;

		[SerializeField]
		private Axis axis;

		[SerializeField]
		[Space]
		private List<RectTransform> transformsToFlip;

		private bool isFlippedHorizontally;

		private bool isFlippedVertically;

		private bool IsHorizontal => false;

		private bool IsVertical => false;

		private void Update()
		{
		}

		private void CheckHorizontalFlip()
		{
		}

		private void CheckVerticalFlip()
		{
		}

		private void Flip(bool horizontally = false, bool vertically = false)
		{
		}
	}
}
