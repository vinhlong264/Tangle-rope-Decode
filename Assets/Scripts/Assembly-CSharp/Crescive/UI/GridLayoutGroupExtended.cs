using UnityEngine;
using UnityEngine.UI;

namespace Crescive.UI
{
	[AddComponentMenu("Layout/Grid Layout Group Extended", 152)]
	public class GridLayoutGroupExtended : LayoutGroup
	{
		public enum StartPosition
		{
			UpperLeft = 0,
			UpperRight = 1,
			LowerLeft = 2,
			LowerRight = 3,
			TopCenter = 4,
			BottomCenter = 5,
			LeftCenter = 6,
			RightCenter = 7,
			Center = 8
		}

		public enum Axis
		{
			Horizontal = 0,
			Vertical = 1
		}

		public enum Constraint
		{
			Flexible = 0,
			FixedColumnCount = 1,
			FixedRowCount = 2
		}

		[SerializeField]
		protected StartPosition m_StartPosition;

		[SerializeField]
		protected Axis m_StartAxis;

		[SerializeField]
		private Vector3 m_ChildScale;

		[SerializeField]
		protected Vector2 m_CellSize;

		[SerializeField]
		protected Vector2 m_Spacing;

		[SerializeField]
		protected Constraint m_Constraint;

		[SerializeField]
		protected int m_ConstraintCount;

		public StartPosition startPosition
		{
			get
			{
				return default(StartPosition);
			}
			set
			{
			}
		}

		public Vector3 childScale
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Axis startAxis
		{
			get
			{
				return default(Axis);
			}
			set
			{
			}
		}

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

		public Constraint constraint
		{
			get
			{
				return default(Constraint);
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

		protected GridLayoutGroupExtended()
		{
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

		private void SetCellsAlongAxis(int axis)
		{
		}

		private void GetPositionForCellIndex(int cellIndex, int cellsPerMainAxis, int cellCountX, int cellCountY, out int positionX, out int positionY)
		{
			positionX = default(int);
			positionY = default(int);
		}
	}
}
