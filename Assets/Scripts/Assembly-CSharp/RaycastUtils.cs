using UnityEngine;

public static class RaycastUtils
{
	public static bool IsPointerOverUI()
	{
		return false;
	}

	public static bool Raycast(out RaycastHit raycastHit, Ray ray, LayerMask layerMask, float maxDistance = float.MaxValue)
	{
		raycastHit = default(RaycastHit);
		return false;
	}

	public static bool RaycastFromMousePosition(out RaycastHit raycastHit, LayerMask layerMask, Camera camera = null, float maxDistance = float.MaxValue)
	{
		raycastHit = default(RaycastHit);
		return false;
	}

	public static bool SphereCastAllFromMousePosition(float radius, out RaycastHit[] raycastHits, LayerMask layerMask, Camera camera = null, float maxDistance = float.MaxValue)
	{
		raycastHits = null;
		return false;
	}
}
