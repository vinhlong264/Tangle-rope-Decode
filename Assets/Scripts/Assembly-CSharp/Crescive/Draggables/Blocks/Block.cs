using UnityEngine;

namespace Crescive.Draggables.Blocks
{
	public class Block : MonoBehaviour
	{
		[SerializeField]
		private DraggableDelegate draggableDelegate;

		[SerializeField]
		private Transform ghostPivot;

		[SerializeField]
		private Transform modelPivot;

		private BlockGroup blockGroup;

		private Vector3 originalLocalPosition;

		private Quaternion originalLocalRotation;

		private Quaternion originalRotation;

		private Transform ghostPivotParent;

		public Transform ModelPivot => null;

		public BlockGroup BlockGroup => null;

		public Vector3 OriginalLocalPosition => default(Vector3);

		public Quaternion OriginalLocalRotation => default(Quaternion);

		public Quaternion OriginalRotation => default(Quaternion);

		public Vector3 BlockPoint => default(Vector3);

		public BlockSlot CurrentSlot => null;

		public BlockSlot ClosestSlot => null;

		private void Awake()
		{
		}

		private void OnDrawGizmos()
		{
		}

		public void Initialize(BlockGroup group)
		{
		}

		public void EnableAndSnapGhostAtSlot(BlockSlot slot)
		{
		}

		public void DisableAndResetGhost()
		{
		}

		public void CacheOriginalPose()
		{
		}
	}
}
