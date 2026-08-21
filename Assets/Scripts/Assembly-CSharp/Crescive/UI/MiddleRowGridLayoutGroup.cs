using UnityEngine;
using UnityEngine.UI;

namespace Crescive.UI
{
	[AddComponentMenu("Layout/Middle Row Grid Layout Group", 154)]
	[ExecuteAlways]
	public class MiddleRowGridLayoutGroup : LayoutGroup
	{
		[SerializeField]
		protected Vector2 m_CellSize;

		[SerializeField]
		protected Vector2 m_Spacing;

		[SerializeField]
		protected int m_Columns;

		[SerializeField]
		protected bool m_FillRowsCompletely;

		public Vector2 cellSize
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 spacing
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public int columns
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool fillRowsCompletely
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override void CalculateLayoutInputHorizontal()
		{
		}

		private int[] CalculateItemPositions(int childCount)
		{
			return null;
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
	}
}
