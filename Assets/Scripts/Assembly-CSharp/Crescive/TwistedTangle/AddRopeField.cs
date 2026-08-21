using System.Collections.Generic;
using Crescive.Draggables;
using Crescive.Draggables.EventParams;
using Crescive.Prefabs;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public class AddRopeField : MonoBehaviour
	{
		[SerializeField]
		private PrefabSource ropeWithPinsPrefabSource;

		[SerializeField]
		private List<BaseDropTargetHolder> ropeHolders;

		[SerializeField]
		private RopesChannel ropeChannel;

		[SerializeField]
		private DropTargetHoldersChannel dropTargetHoldersChannel;

		public UnityEvent OnFieldEmpty;

		public UnityEvent OnFieldFull;

		[SerializeField]
		private VoidEvent emptyEvent;

		private bool isFieldFull;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void DestroyRope(RopeEntity rope)
		{
		}

		private void Start()
		{
		}

		private void OnHolderUpdated(HolderEventParams holderEventParams)
		{
		}

		private void CheckFields()
		{
		}

		private void PerformAddRope()
		{
		}

		public void Add()
		{
		}
	}
}
