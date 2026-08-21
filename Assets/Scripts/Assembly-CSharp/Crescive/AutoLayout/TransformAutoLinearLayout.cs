using UnityEngine;

namespace Crescive.AutoLayout
{
	public class TransformAutoLinearLayout : TransformAutoLayout
	{
		public enum TransformAutoLinearLayoutAnchor
		{
			Beginning = 0,
			Center = 1,
			End = 2
		}

		public enum TransformAutoLinearLayoutAxis
		{
			X = 0,
			Y = 1,
			Z = 2
		}

		[SerializeField]
		private TransformAutoLinearLayoutAnchor anchor;

		[SerializeField]
		private TransformAutoLinearLayoutAxis axis;

		[SerializeField]
		private bool reversed;

		[SerializeField]
		private float spacing;

		[SerializeField]
		private Vector3 baseOffset;

		[SerializeField]
		private float itemWidth;

		private void Update()
		{
		}

		private Vector3 GetItemPositionAtIndexWithOffset(int i, float offset)
		{
			return default(Vector3);
		}

		private float CalculateOffsetForItemCount(int itemCount)
		{
			return 0f;
		}

		public override void UpdateLayout()
		{
		}

		public override Vector3 GetItemPositionAtIndexForItemCount(int i, int itemCount)
		{
			return default(Vector3);
		}
	}
}
