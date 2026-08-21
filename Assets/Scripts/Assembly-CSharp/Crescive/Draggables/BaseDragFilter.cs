using UnityEngine;

namespace Crescive.Draggables
{
	public abstract class BaseDragFilter : MonoBehaviour
	{
		public abstract bool CanDrag(Draggable draggable);
	}
}
