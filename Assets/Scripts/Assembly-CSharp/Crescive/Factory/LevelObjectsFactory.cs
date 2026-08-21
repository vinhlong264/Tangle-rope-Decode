using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Factory
{
	[CreateAssetMenu(fileName = "LevelObjectsFactory", menuName = "ScriptableObjects/Factory/LevelObjectsFactory")]
	public class LevelObjectsFactory : BaseGameObjectFactory
	{
		[SerializeField]
		[Header("Settings")]
		private List<LevelFactoryData> factoriesByLevel;

		public GameObjectFactory GetFactoryForLevel(int level)
		{
			return null;
		}

		public override TComponent Create<TComponent>(Vector3? pos = null, Quaternion? rot = null, Vector3? scale = null, Transform parent = null)
		{
			return null;
		}
	}
}
