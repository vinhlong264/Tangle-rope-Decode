using Crescive.Scriptables;
using UnityEngine;

namespace Crescive.Levels
{
	[CreateAssetMenu(fileName = "CurrentLevelDifficultyPropertyForPlayButton", menuName = "GameData/Levels/CurrentLevelDifficultyPropertyForPlayButton")]
	public class CurrentLevelDifficultyPropertyForPlayButton : StringScriptableProperty
	{
		[SerializeField]
		private LevelDifficultyTransformer difficultyTransformer;

		protected override string GetValue()
		{
			return null;
		}
	}
}
