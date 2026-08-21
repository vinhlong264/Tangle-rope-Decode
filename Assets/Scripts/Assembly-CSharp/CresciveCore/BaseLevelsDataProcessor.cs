using System.Collections.Generic;
using UnityEngine;

namespace CresciveCore
{
	public abstract class BaseLevelsDataProcessor<T> : ScriptableObject
	{
		public abstract List<T> ProcessLevelsData(List<T> levels);

		public abstract List<T> ProcessExceptedLevelsOnLoop(List<T> levels);
	}
}
