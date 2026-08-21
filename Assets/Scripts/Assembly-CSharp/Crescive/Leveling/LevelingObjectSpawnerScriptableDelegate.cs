using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Leveling
{
	[CreateAssetMenu(fileName = "LevelingObjectSpawnDelegate", menuName = "LevelingComponent/LevelingObjectSpawnDelegate")]
	public class LevelingObjectSpawnerScriptableDelegate : ScriptableObject
	{
		private LevelingObjectSpawner spawner;

		public LevelingObjectSpawner Spawner => null;

		public int Count => 0;

		public List<LevelingBehaviour> Items => null;

		public int CountByLevel(int level)
		{
			return 0;
		}

		public LevelingBehaviour AddItem(int level)
		{
			return null;
		}

		public T AddItem<T>(int level) where T : LevelingBehaviour
		{
			return null;
		}

		public void TryAddItem<T>(int level, out T item)
		{
			item = default(T);
		}

		public void RemoveItem(LevelingBehaviour item)
		{
		}

		public void RemoveItemAndDestroy(LevelingBehaviour item)
		{
		}

		public void SetData(LevelingObjectSpawner spawner)
		{
		}
	}
}
