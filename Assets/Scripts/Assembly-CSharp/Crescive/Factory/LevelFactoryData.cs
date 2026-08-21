using System;

namespace Crescive.Factory
{
	[Serializable]
	public struct LevelFactoryData
	{
		public int level;

		public GameObjectFactory factory;
	}
}
