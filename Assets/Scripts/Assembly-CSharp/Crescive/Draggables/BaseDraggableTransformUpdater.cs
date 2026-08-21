using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Draggables
{
	public abstract class BaseDraggableTransformUpdater : ScriptableObject
	{
		[SerializeField]
		private List<BaseDragPositionClamper> dragPositionClampers;

		public void UpdateTransform(Draggable draggable, Vector3 position)
		{
		}

		protected abstract void UpdateTransformInternal(Draggable draggable, Vector3 position);
	}
}
