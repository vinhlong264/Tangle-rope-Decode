using Crescive.Pooling;
using Crescive.Prefabs;
using UnityEngine;

namespace Crescive.Factory
{
	[CreateAssetMenu(fileName = "GameObjectFactory", menuName = "ScriptableObjects/Factory/GameObjectFactory")]
	public class GameObjectFactory : BaseGameObjectFactory
	{
		private enum FactoryType
		{
			Prefab = 0,
			PrefabSource = 1,
			Pooler = 2
		}

		[SerializeField]
		private FactoryType factoryType;

		[SerializeField]
		private GameObject prefab;

		[SerializeField]
		private PrefabSource prefabSource;

		[SerializeField]
		private ObjectPoolerScriptableDelegate pooler;

		private IObjectPooler Pooler => null;

		public GameObject Prefab => null;

		public GameObject Create(Vector3? pos = null, Quaternion? rot = null, Vector3? scale = null, Transform parent = null)
		{
			return null;
		}

		public GameObject Create(Transform parent)
		{
			return null;
		}

		public override TComponent Create<TComponent>(Vector3? pos = null, Quaternion? rot = null, Vector3? scale = null, Transform parent = null)
		{
			return null;
		}

		public TComponent Create<TComponent>(Transform parent) where TComponent : Component
		{
			return null;
		}

		public void CreateAtTarget(Transform target)
		{
		}

		public void CreateAtPosition(Vector3 pos)
		{
		}

		public void CreateAtPositionWithScaleFloat(Vector3 pos, float scale)
		{
		}

		public void CreateAtPositionWithScaleFloat(Vector3 pos, Vector3 scale)
		{
		}

		public void DestroyInstance(GameObject obj, float delay = 0f)
		{
		}

		public void DestroyInstance(Component comp, float delay = 0f)
		{
		}
	}
	public abstract class GameObjectFactory<TComponent> : ScriptableObject where TComponent : Component
	{
		[SerializeField]
		private TComponent prefab;

		public TComponent Prefab => null;

		public TComponent Create(Vector3? pos = null, Quaternion? rot = null, Transform parent = null)
		{
			return null;
		}

		public void CreateAtTarget(Transform target)
		{
		}

		public void CreateAtPosition(Vector3 pos)
		{
		}
	}
}
