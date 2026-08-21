using UnityEngine.Events;

namespace Crescive.Leveling
{
	public interface ILevelingValue
	{
		int Level { get; }

		UnityEvent<int> OnLevelChanged { get; }

		UnityEvent<int> OnLevelIncreased { get; }

		UnityEvent<int> OnLevelDecreased { get; }

		void SetLevel(int newLevel);

		void IncreaseLevel(int amount = 1);

		void DecreaseLevel(int amount = 1);
	}
}
