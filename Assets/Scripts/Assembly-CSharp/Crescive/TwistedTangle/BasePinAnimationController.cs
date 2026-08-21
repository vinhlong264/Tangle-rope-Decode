using Crescive.Draggables;
using Crescive.Draggables.EventParams;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public abstract class BasePinAnimationController : MonoBehaviour
	{
		[SerializeField]
		protected MeshRendererColorSetter colorSetter;

		[SerializeField]
		protected PinMergeDelegate pinMergeDelegate;

		[SerializeField]
		protected BaseDraggableListener draggableListener;

		public UnityEvent<Color> OnColorUpdated;

		public UnityEvent<Vector3> OnGrabbed;

		public UnityEvent<Vector3> OnDropped;

		public UnityEvent<Vector3> OnJumpAnimCompleted;

		protected virtual void OnEnable()
		{
		}

		private void Start()
		{
		}

		protected virtual void OnDisable()
		{
		}

		private void OnColorUpdatedCallback(Color color)
		{
		}

		private void OnGrabbedCallback(DraggableEventParams args)
		{
		}

		private void OnDroppedCallback(DraggableDropEventParams args)
		{
		}

		private void OnJumpAnimCompletedCallback(bool isSource)
		{
		}

		protected virtual void OnColorUpdatedInternal(Color newColor)
		{
		}

		protected virtual void OnGrabbedInternal()
		{
		}

		protected virtual void OnDroppedInternal()
		{
		}

		protected virtual void OnJumpAnimCompletedInternal()
		{
		}
	}
}
