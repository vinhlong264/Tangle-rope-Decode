using UnityEngine;

namespace Crescive.Leveling
{
	[CreateAssetMenu(menuName = "ScriptableObjects/Leveling/LevelingFloat", fileName = "LevelingFloat")]
	public class LevelingFloat : LevelingVariable<float>
	{
		public override float GetAccumulatedValueForLevel(int level)
		{
			return 0f;
		}
	}
}
