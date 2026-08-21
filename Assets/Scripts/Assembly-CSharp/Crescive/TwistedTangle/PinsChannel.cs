using System.Collections.Generic;
using Crescive.Channels;
using Crescive.Draggables;
using Crescive.HelperTypes;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	[CreateAssetMenu(fileName = "PinsChannel", menuName = "GameData/Map/Channels/Pins Channel")]
	public class PinsChannel : ObjectsChannel<PinEntity>
	{
		[SerializeField]
		private PinSlotsChannel pinSlotsChannel;

		[SerializeField]
		private DropTargetHoldersChannel holdersChannel;

		[SerializeField]
		private FloatVariableReference maxPinsDistance;

		public float MaxPinsDistance => 0f;

		public float MaxPinsDistanceSqr => 0f;

		public bool IsAllPinsConnected => false;

		public PinEntity GetClosestPin(Vector3 pos)
		{
			return null;
		}

		public PinEntity GetClosestPinInDistance(Vector3 pos, float maxDistance)
		{
			return null;
		}

		public PinEntity GetClosestPinInDistance(Vector3 pos, float maxDistance, PinEntity excludePin)
		{
			return null;
		}

		public PinEntity GetClosestPinInDistance(Vector3 pos, float maxDistance, List<PinEntity> excludePins)
		{
			return null;
		}

		public List<PinEntity> GetPinsInDistance(Vector3 pos, float distance)
		{
			return null;
		}

		public List<PinSlotEntity> GetReachableSlots(Vector3 position, bool includeOnlyEmpties = true)
		{
			return null;
		}

		public List<PinSlotEntity> GetReachableSlots(PinEntity pin, bool includeOnlyEmpties = true)
		{
			return null;
		}

		public DefaultDropTargetHolder GetPinHolder(PinEntity pinEntity)
		{
			return null;
		}

		public bool TryRemovePinFromHolder(PinEntity pinEntity)
		{
			return false;
		}

		public void RemovePinsFromHolders(IReadOnlyList<PinEntity> pinEntities)
		{
		}

		public void RemoveAllPinsFromHolders()
		{
		}
	}
}
