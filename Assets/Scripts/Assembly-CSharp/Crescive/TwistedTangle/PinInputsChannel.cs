using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	[CreateAssetMenu(fileName = "PinInputsChannel", menuName = "GameData/Channel/PinInputsChannel")]
	public class PinInputsChannel : ScriptableObject
	{
		public UnityEvent<PinMoveEventArgs> OnMoveStarted;

		public UnityEvent<PinMoveEventArgs> OnMoveEnded;

		public UnityEvent<PinMoveEventArgs> OnMoveCanceled;

		public UnityEvent<PinMoveEventArgs> OnMoveCompleted;

		public UnityEvent<PinMoveSlotEventArgs> OnMoveToOtherSlot;

		public UnityEvent<PinMoveSlotEventArgs> OnMoveToSameSlot;

		[field: SerializeField]
		public List<PinEntity> CurrentPinEntities { get; private set; }

		public void ResetData()
		{
		}
	}
}
