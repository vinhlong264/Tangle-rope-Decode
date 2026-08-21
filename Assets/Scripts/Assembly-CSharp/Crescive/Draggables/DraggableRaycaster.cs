using UnityEngine;

namespace Crescive.Draggables
{
	[CreateAssetMenu(fileName = "DraggableRaycaster", menuName = "Draggables/Raycaster/DraggableRaycaster")]
	public class DraggableRaycaster : ScriptableObject
	{
		[SerializeField]
		[Header("Settings")]
		private LayerMask draggableMask;

		[SerializeField]
		private LayerMask dragSurfaceMask;

		[SerializeField]
		private LayerMask dropTargetMask;

		[Space]
		[SerializeField]
		private Vector3 helperRayDirection;

		[SerializeField]
		private LayerMask helperSurfaceMask;

		private Camera cam;

		public void SetData(Camera mainCamera)
		{
		}

		protected virtual Ray GetDraggableRay()
		{
			return default(Ray);
		}

		protected virtual Ray GetDragSurfaceRay()
		{
			return default(Ray);
		}

		protected virtual Ray GetHelperSurfaceRay()
		{
			return default(Ray);
		}

		protected virtual Ray GetHelperToDragSurfaceRay(Vector3 origin)
		{
			return default(Ray);
		}

		protected virtual Ray GetDropTargetsRay(Draggable draggable, RaycastHit dragSurfaceHit)
		{
			return default(Ray);
		}

		private bool Raycast(out RaycastHit raycastHit, Ray ray, LayerMask layerMask)
		{
			raycastHit = default(RaycastHit);
			return false;
		}

		private bool RaycastMultiple(ref RaycastHit[] raycastHit, out int hitCount, Ray ray, LayerMask layerMask)
		{
			hitCount = default(int);
			return false;
		}

		private bool RaycastAll(out RaycastHit[] raycastHits, Ray ray, LayerMask layerMask)
		{
			raycastHits = null;
			return false;
		}

		public bool RaycastDraggable(out RaycastHit raycastHit)
		{
			raycastHit = default(RaycastHit);
			return false;
		}

		public bool RaycastDraggables(out RaycastHit[] raycastHit, out int hitCount)
		{
			raycastHit = null;
			hitCount = default(int);
			return false;
		}

		public bool RaycastDragSurface(out RaycastHit raycastHit)
		{
			raycastHit = default(RaycastHit);
			return false;
		}

		public bool RaycastDropTargets(out RaycastHit[] raycastHits, Draggable draggable, RaycastHit dragSurfaceHit)
		{
			raycastHits = null;
			return false;
		}

		public bool RaycastDropTargetsOnTap(out RaycastHit[] raycastHits, out Ray ray)
		{
			raycastHits = null;
			ray = default(Ray);
			return false;
		}
	}
}
