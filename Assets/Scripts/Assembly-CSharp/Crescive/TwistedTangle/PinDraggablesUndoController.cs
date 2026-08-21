using Crescive.Draggables;
using Crescive.Draggables.EventParams;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class PinDraggablesUndoController : MonoBehaviour
	{
		[SerializeField]
		private DraggablesControllerChannel controllerChannel;

		[SerializeField]
		private DropTargetHoldersChannel holdersChannel;

		[SerializeField]
		[Range(0f, 1f)]
		private float maxRopeTensionPercentage;

		[SerializeField]
		private RopesChannel ropesChannel;

		[SerializeField]
		private float undoCheckDelay;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnHoldersDataChanged()
		{
		}

		private void SubscribeHolders()
		{
		}

		private void UnsubscribeHolders()
		{
		}

		private void OnDroppedToAnotherTarget(HolderDropAnotherEventParams arg0)
		{
		}
	}
}
