using UnityEngine.Events;

namespace Crescive.Leveling
{
	public class LevelingFloatListener : LevelingVariableListener<float>
	{
		public UnityEvent<int> OnChangedValueRoundToInt;

		protected override void TriggerLevelingChanged(int leveling)
		{
		}
	}
}
