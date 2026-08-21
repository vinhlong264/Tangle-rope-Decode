using System;
using Crescive.Draggables;
using UnityEngine;

namespace Crescive.CreatorMode
{
	[Serializable]
	public class ColumnData : ICloneable
	{
		public Vector3 Position;

		public ColumnData(Draggable columnDraggable)
		{
		}

		public ColumnData(ColumnData copy)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
