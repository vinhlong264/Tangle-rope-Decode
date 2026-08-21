using UnityEngine;

namespace Crescive.CreatorMode
{
	public abstract class BaseCreatorSaveDataProcessor<T> : ScriptableObject where T : class
	{
		public abstract T ProcessSaveData(T saveData);
	}
}
