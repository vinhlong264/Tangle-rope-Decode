using BrunoMikoski.AnimationSequencer;
using Crescive.Draggables;
using Crescive.Utils;
using Shapes;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class PinSlotEntity : MonoBehaviour
	{
		[SerializeField]
		public Color DefaultPinRendererColor;

		[SerializeField]
		public DefaultDropTargetHolder DropTargetHolder;

		private bool isColoredMode;

		public bool EditorSlot;

		[field: SerializeField]
		public Lock Locker { get; private set; }

		[field: SerializeField]
		public ObjectSelector Selector { get; private set; }

		[field: SerializeField]
		public ShapeRenderer PinSlotRenderer { get; private set; }

		[field: SerializeField]
		public ShapeRenderer PinSlotSelectedOutlineRenderer { get; private set; }

		[field: SerializeField]
		public ShapeRenderer PinSlotCurrentDraggedPinOutlineRenderer { get; private set; }

		[field: SerializeField]
		public SpriteRenderer ColoredModePinSlotMiddleRenderer { get; private set; }

		[field: SerializeField]
		public float defaultScale { get; private set; }

		[field: SerializeField]
		public float previousScale { get; private set; }

		[field: SerializeField]
		public AnimationSequencerController animationSequencerController { get; private set; }

		public Color Color { get; private set; }

		private void Awake()
		{
		}

		public void SetColor(Color c)
		{
		}

		public void OnDropTargetSelected()
		{
		}

		public void OnDropTargetUnselected()
		{
		}

		public void OnMoveStartedThisPin()
		{
		}

		public void OnMoveEndedThisPin()
		{
		}

		public void SetLock(bool isLocked)
		{
		}

		public void ToggleLock(bool isLocked)
		{
		}
	}
}
