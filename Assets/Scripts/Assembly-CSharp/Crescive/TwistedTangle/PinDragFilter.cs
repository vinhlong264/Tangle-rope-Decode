using Crescive.Draggables;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class PinDragFilter : BaseDragFilter
	{
		[SerializeField]
		[Range(0f, 1f)]
		private float maxRopeTensionPercentage;

		[SerializeField]
		private RopesChannel ropesChannel;

		[SerializeField]
		private bool checkContacts;

		[SerializeField]
		private bool enable;

		public override bool CanDrag(Draggable draggable)
		{
			return false;
		}

		public void SetEnable(bool enable)
		{
		}
	}
}
