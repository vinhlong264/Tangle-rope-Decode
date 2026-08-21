using UnityEngine;

namespace Crescive.Factory
{
	public static class GameObjectFactoryHelpers
	{
		public static GameObject CreateFromPrefab(GameObject prefab, Vector3? pos, Quaternion? rot, Vector3? scale, Transform parent)
		{
			return null;
		}

		public static T CreateFromPrefab<T>(GameObject prefab, Vector3? pos, Quaternion? rot, Vector3? scale, Transform parent)
		{
			return default(T);
		}

		public static T CreateFromPrefab<T>(T prefab, Vector3? pos, Quaternion? rot, Vector3? scale, Transform parent) where T : Component
		{
			return null;
		}
	}
}
