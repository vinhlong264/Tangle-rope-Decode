using System;

namespace UnityEngine.UI
{
	[AddComponentMenu("Layout/Flexible Grid Layout Group", 156)]
	[RequireComponent(typeof(RectTransform))]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[SelectionBase]
	public class FlexibleGridLayoutGroup : LayoutGroup, ILayoutSelfController, ILayoutController
	{
		[Serializable]
		private enum BasicDirection
		{
			Vertical = 0,
			Horizontal = 1
		}

		[SerializeField]
		public int CellsPerLine;

		[SerializeField]
		public int Spacing;

		[SerializeField]
		public float CellAspectRatio;

		private int fixedCellsPerLine;

		private int fixedSpacing;

		private float fixedCellAspectRatio;

		[SerializeField]
		private BasicDirection direction;

		private BasicDirection old_direction;

		private Vector2 cellSize;

		private int linesCount;

		private float referenceRectSize;

		private float requestedRectSize;

		protected override void OnDisable()
		{
		}

		public override void CalculateLayoutInputVertical()
		{
		}

		public override void SetLayoutHorizontal()
		{
		}

		public override void SetLayoutVertical()
		{
		}

		private void ReplaceCells()
		{
		}

		private void FixUserInput()
		{
		}

		private void TryDetectDirectionChange()
		{
		}

		private void ReplaceCellsHorizontal()
		{
		}

		private void ReplaceCellsVertical()
		{
		}
	}
}
