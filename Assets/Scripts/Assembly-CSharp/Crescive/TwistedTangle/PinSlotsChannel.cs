using System.Collections.Generic;
using Crescive.Channels;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	[CreateAssetMenu(fileName = "PinSlotsChannel", menuName = "GameData/Map/Channels/Pinslots Channel")]
	public class PinSlotsChannel : ObjectsChannel<PinSlotEntity>
	{
		public List<PinSlotEntity> LockedPinSlots => null;

		public List<PinSlotEntity> EmptySlots => null;

		public bool HasEmptySlots => false;

		public List<PinSlotEntity> GetSlotsInDistance(Vector3 pos, float distance)
		{
			return null;
		}

		public PinSlotEntity GetRandomEmptySlot()
		{
			return null;
		}

		public void Sort()
		{
		}
	}
}
