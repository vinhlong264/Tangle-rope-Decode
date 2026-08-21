using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Factory
{
	[CreateAssetMenu(fileName = "RandomGameObjectFactory", menuName = "ScriptableObjects/Factory/RandomGameObjectFactory")]
	public class RandomGameObjectFactory : BaseGameObjectFactory
	{
		[SerializeField]
		[Header("Settings")]
		private List<GameObjectFactory> factories;

		public GameObjectFactory GetRandomFactory()
		{
			return null;
		}

		public override TComponent Create<TComponent>(Vector3? pos = null, Quaternion? rot = null, Vector3? scale = null, Transform parent = null)
		{
			return null;
		}
	}
}
