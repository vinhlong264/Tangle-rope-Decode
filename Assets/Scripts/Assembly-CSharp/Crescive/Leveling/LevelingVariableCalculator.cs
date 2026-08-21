using UnityEngine;

namespace Crescive.Leveling
{
	public abstract class LevelingVariableCalculator<T> : ScriptableObject
	{
		public abstract T Calculate(int level);
	}
}
