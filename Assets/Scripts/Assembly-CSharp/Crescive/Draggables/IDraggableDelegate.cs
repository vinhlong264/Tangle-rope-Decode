using UnityEngine;

namespace Crescive.Draggables
{
	public interface IDraggableDelegate
	{
		Draggable TargetDraggable { get; }

		Bounds HitBounds { get; }
	}
}
