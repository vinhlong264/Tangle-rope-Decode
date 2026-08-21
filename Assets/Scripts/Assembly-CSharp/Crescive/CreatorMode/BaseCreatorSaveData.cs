using System;

namespace Crescive.CreatorMode
{
	public abstract class BaseCreatorSaveData : ICloneable
	{
		private int _levelId;

		public abstract object Clone();

		public abstract string ToJson();

		public int GetLevelId()
		{
			return 0;
		}

		public void SetLevelId(int levelId)
		{
		}
	}
}
