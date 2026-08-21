using UnityEngine;
using UnityEngine.UI;

namespace Crescive.UI
{
	[ExecuteAlways]
	[AddComponentMenu("Layout/Center Out Grid Layout Group", 153)]
	public class CenterOutGridLayoutGroup : LayoutGroup
	{
		[SerializeField]
		protected Vector2 m_CellSize;

		[SerializeField]
		protected Vector2 m_Spacing;

		[SerializeField]
		protected int m_Columns;

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

		public override void CalculateLayoutInputHorizontal()
		{
		}

		private int[] CalculateChildrenPerRow(int childCount, int rowCount)
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
