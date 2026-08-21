using System.Collections.Generic;
using Crescive.Command;
using Crescive.CreatorMode;
using Crescive.Draggables;
using Crescive.Draggables.EventParams;
using Crescive.Levels;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class MapCommandAdder : MonoBehaviour
	{
		[SerializeField]
		private DraggablesControllerChannel draggablesControllerChannel;

		[SerializeField]
		private LevelSaverChannel levelSaverChannel;

		[SerializeField]
		private LevelCreatorChannel levelCreatorChannel;

		[SerializeField]
		private DropTargetHoldersChannel holdersChannel;

		[SerializeField]
		private CommandChannel commandChannel;

		[SerializeField]
		private RopesChannel ropesChannel;

		[SerializeField]
		private PinsChannel pinsChannel;

		[SerializeField]
		private LoadedLevelDataChannel loadedLevelDataChannel;

		private LevelCreatorSaveData levelCreatorSaveData;

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

		private void OnDraggablesControllerSelect(DraggableEventParams arg0)
		{
		}

		private void SaveMapState()
		{
		}

		private List<PinEntity> GetValidPins()
		{
			return null;
		}

		private void FixPinAndRopesInSaveData(LevelCreatorSaveData saveData, PinEntity pinEntity)
		{
		}

		private void OnDroppedToAnotherTarget(HolderDropAnotherEventParams arg0)
		{
		}

		private void AddUpdateLevelCommand()
		{
		}
	}
}
