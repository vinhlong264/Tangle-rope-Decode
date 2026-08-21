using System;
using System.Collections.Generic;
using Crescive.Draggables;
using Crescive.HelperTypes;
using DG.Tweening;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class MapShuffler : MonoBehaviour
	{
		[Serializable]
		private class MapData
		{
			public RopesChannel RopesChannel;

			public PinsChannel PinsChannel;

			public PinSlotsChannel SlotsChannel;

			public Dictionary<PinSlotEntity, SlotData> SlotsData;

			public MapData(RopesChannel ropesChannel, PinsChannel pinsChannel, PinSlotsChannel slotsChannel)
			{
			}

			public List<PinSlotEntity> GetReachablePinSlots(Vector3 position)
			{
				return null;
			}

			public bool HasReachablePinSlots(PinEntity pin)
			{
				return false;
			}
		}

		[Serializable]
		private struct SlotData
		{
			public PinSlotEntity Slot;

			public Draggable Draggable;

			public bool IsFull => false;

			public bool IsEmpty => false;

			public SlotData(PinSlotEntity slot)
			{
				Slot = null;
				Draggable = null;
			}

			public SlotData(PinSlotEntity slot, Draggable draggable)
			{
				Slot = null;
				Draggable = null;
			}
		}

		[SerializeField]
		private RopesChannel ropesChannel;

		[SerializeField]
		private PinsChannel pinsChannel;

		[SerializeField]
		private PinSlotsChannel slotsChannel;

		[SerializeField]
		private DropTargetHoldersChannel holdersChannel;

		[SerializeField]
		private float jumpPower;

		[SerializeField]
		private float animationDuration;

		[SerializeField]
		private FloatVariableReference highTensionThreshold;

		[SerializeField]
		private float saveHighTensionRopesDelay;

		[SerializeField]
		private float highTensionPhysicActivateDelay;

		private void SaveHighTensionRopesDelayed()
		{
		}

		private void SaveHighTensionRopes()
		{
		}

		private Tween PlaceDraggablesToSlots(MapData mapData)
		{
			return null;
		}

		private MapData GetShuffledMapData()
		{
			return null;
		}

		private void ShuffleRopePinsEachOther(MapData mapData)
		{
		}

		private void ExchangeAllConnectedRopes(List<List<ConnectedRope>> allExchangeConnectedRopes, MapData mapData)
		{
		}

		private void ExchangeConnectedRopes(ConnectedRope cr1, ConnectedRope cr2, MapData mapData)
		{
		}

		private void ApplyMapDataInstantly(MapData mapData)
		{
		}

		public void ShuffleMap()
		{
		}

		public void ShuffleMapInstantly()
		{
		}
	}
}
