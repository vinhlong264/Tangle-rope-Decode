using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.AutoLayout
{
	public class TransformAutoGridLayout : TransformAutoLayout
	{
		public enum GridPlane
		{
			XY = 0,
			XZ = 1,
			YZ = 2
		}

		[SerializeField]
		private GridPlane plane;

		[SerializeField]
		private TextAnchor childAlignment;

		[SerializeField]
		private int columns;

		[SerializeField]
		private Vector2 spacing;

		public UnityEvent OnLayoutUpdated;

		[SerializeField]
		private GroundSkinController groundSkinController;

		public int Columns => 0;

		public int Rows => 0;

		public List<Transform> OrderedActiveItems => null;

		public void SetColumns(int value)
		{
		}

		private void OnValidate()
		{
		}

		private void SetColumnPosition(ref Vector3 pos, float value)
		{
		}

		private void SetRowPosition(ref Vector3 pos, float value)
		{
		}

		private Vector3 Align(ref Vector3 pos, int itemCount)
		{
			return default(Vector3);
		}

		private List<Transform> GetActiveItemsOrdered()
		{
			return null;
		}

		public override void UpdateLayout()
		{
		}

		public override Vector3 GetItemPositionAtIndexForItemCount(int i, int itemCount)
		{
			return default(Vector3);
		}

		public int GetRows(int itemCount)
		{
			return 0;
		}

		public int GetItemIndex(int row, int column)
		{
			return 0;
		}

		public int GetItemIndex(Transform item)
		{
			return 0;
		}

		public int GetItemIndex(Behaviour item)
		{
			return 0;
		}

		public Transform GetItem(int row, int column)
		{
			return null;
		}

		public int GetItemRow(Transform item)
		{
			return 0;
		}

		public int GetItemColumn(Transform item)
		{
			return 0;
		}

		public void ResetAllPinsRotation()
		{
		}
	}
}
