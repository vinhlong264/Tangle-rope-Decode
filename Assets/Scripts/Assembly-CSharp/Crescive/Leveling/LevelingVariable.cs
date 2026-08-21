using UnityEngine;

namespace Crescive.Leveling
{
	public abstract class LevelingVariable<T> : ScriptableObject
	{
		[SerializeField]
		[Header("References")]
		protected LevelingData leveling;

		[SerializeField]
		protected LevelingVariableCalculator<T> calculator;

		public LevelingData Leveling => null;

		public LevelingVariableCalculator<T> Calculator => null;

		public int Level => 0;

		public T Value => default(T);

		public void SetLevel(int level)
		{
		}

		public void IncreaseLevel()
		{
		}

		public void DecreaseLevel()
		{
		}

		public T GetValueAtLevel(int level)
		{
			return default(T);
		}

		public virtual T GetAccumulatedValueForLevel(int level)
		{
			return default(T);
		}
	}
}
