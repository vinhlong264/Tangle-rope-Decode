using Crescive.Draggables;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class RemoveRopeController : BaseRopeSelectToggler
	{
		[SerializeField]
		private DropTargetHoldersChannel dropTargetHoldersChannel;

		protected override void OnHitRope(RopeRaycastData ropeRaycastData)
		{
		}

		private void DestroyRope(RopeEntity rope)
		{
		}
	}
}
