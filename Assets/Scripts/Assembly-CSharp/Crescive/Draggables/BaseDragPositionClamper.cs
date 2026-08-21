using UnityEngine;

namespace Crescive.Draggables
{
	public abstract class BaseDragPositionClamper : ScriptableObject
	{
		public abstract Vector3 ClampPosition(Draggable draggable, Vector3 position);
	}
}
