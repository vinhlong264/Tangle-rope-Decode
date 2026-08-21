using UnityEngine;

namespace Crescive.Draggables
{
	[CreateAssetMenu(fileName = "DefaultDraggableTransformUpdater", menuName = "Draggables/Updater/DefaultDraggableTransformUpdater")]
	public class DefaultDraggableTransformUpdater : BaseDraggableTransformUpdater
	{
		[SerializeField]
		private bool useRigidbody;

		[Header("Movement Settings")]
		[SerializeField]
		protected bool lerpPosition;

		[SerializeField]
		protected float moveTime;

		[Header("Rotation Settings")]
		[SerializeField]
		protected bool affectRotation;

		[SerializeField]
		protected bool isRotationReversed;

		[SerializeField]
		protected float wobbleStrength;

		[SerializeField]
		protected float wobbleTime;

		[SerializeField]
		protected Vector2 wobbleMinMaxAngles;

		private void UpdatePosition(Draggable draggable, Vector3 position, out Vector3 targetDirection)
		{
			targetDirection = default(Vector3);
		}

		private void UpdateRotationInternal(Draggable draggable, Vector3 targetDirection)
		{
		}

		protected override void UpdateTransformInternal(Draggable draggable, Vector3 position)
		{
		}
	}
}
