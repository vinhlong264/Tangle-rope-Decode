using System.Collections.Generic;
using Crescive.Draggables;
using Crescive.Draggables.EventParams;
using DG.Tweening;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	[DefaultExecutionOrder(1)]
	public class PinsTapMoveController : MonoBehaviour
	{
		[SerializeField]
		private PinsTapMoveChannel pinsTapMoveChannel;

		[SerializeField]
		private DraggablesControllerChannel draggablesControllerChannel;

		[SerializeField]
		private RopesChannel ropesChannel;

		[SerializeField]
		private PinRopeLimitDragPositionClamper pinRopeLimitDragPositionClamper;

		[SerializeField]
		private PinSlotsChannel pinSlotsChannel;

		[Range(0f, 1f)]
		[SerializeField]
		private float maxRopeTensionPercentage;

		[SerializeField]
		private float clamperMaxDistanceOffset;

		private Tween selectTween;

		private Dictionary<PinEntity, Tween> dropTweens;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SelectPin(PinEntity pin)
		{
		}

		private void DeselectPin()
		{
		}

		private void OnSelectCallback(DraggableEventParams args)
		{
		}

		private void OnGrabCallback(DraggableEventParams args)
		{
		}

		private void OnTapDropTargetCallback(DropTargetEventParams args)
		{
		}

		public void ResetData()
		{
		}
	}
}
