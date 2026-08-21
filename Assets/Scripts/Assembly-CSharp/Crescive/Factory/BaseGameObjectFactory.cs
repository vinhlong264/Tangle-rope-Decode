using UnityEngine;

namespace Crescive.Factory
{
	public abstract class BaseGameObjectFactory : ScriptableObject
	{
		public abstract TComponent Create<TComponent>(Vector3? pos = null, Quaternion? rot = null, Vector3? scale = null, Transform parent = null) where TComponent : Component;
	}
}
