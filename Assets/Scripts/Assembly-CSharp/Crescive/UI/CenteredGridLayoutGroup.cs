using UnityEngine;
using UnityEngine.UI;

namespace Crescive.UI
{
	[AddComponentMenu("Layout/Centered Grid Layout Group", 152)]
	[ExecuteAlways]
	public class CenteredGridLayoutGroup : LayoutGroup
	{
		[SerializeField]
		protected Vector2 m_CellSize;

		[SerializeField]
		protected Vector2 m_Spacing;

		[SerializeField]
		protected GridLayoutGroup.Constraint m_Constraint;

		[SerializeField]
		protected int m_ConstraintCount;

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

		public GridLayoutGroup.Constraint constraint
		{
			get
			{
				return default(GridLayoutGroup.Constraint);
			}
			set
			{
			}
		}

		public int constraintCount
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
