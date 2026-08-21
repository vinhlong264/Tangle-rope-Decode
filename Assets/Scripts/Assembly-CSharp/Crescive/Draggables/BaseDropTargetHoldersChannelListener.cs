using Crescive.Draggables.EventParams;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Draggables
{
	public abstract class BaseDropTargetHoldersChannelListener<TChannel, THolder> : MonoBehaviour where TChannel : BaseDropTargetHoldersChannel<THolder> where THolder : BaseDropTargetHolder
	{
		[SerializeField]
		protected TChannel channel;

		public UnityEvent<HolderEventParams> OnHeld;

		public UnityEvent<HolderEventParams> OnHoldPlaced;

		public UnityEvent<HolderEventParams> OnPlaced;

		public UnityEvent<HolderEventParams> OnRemoved;

		public UnityEvent<HolderDropAnotherEventParams> OnDroppedToAnotherTarget;

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}
	}
}
