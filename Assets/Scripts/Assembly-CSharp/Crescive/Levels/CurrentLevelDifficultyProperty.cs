using Crescive.Scriptables;
using UnityEngine;

namespace Crescive.Levels
{
	[CreateAssetMenu(fileName = "CurrentLevelDifficultyProperty", menuName = "GameData/Levels/Current Level Difficulty Property")]
	public class CurrentLevelDifficultyProperty : StringScriptableProperty
	{
		[SerializeField]
		private LevelDifficultyTransformer difficultyTransformer;

		protected override string GetValue()
		{
			return null;
		}
	}
}
