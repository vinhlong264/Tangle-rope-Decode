using Crescive.Levels;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive
{
	[CreateAssetMenu(menuName = "Crescive/Levels/Level Difficulty Setter Action")]
	public class LevelDifficultySetterAction : StringAction
	{
		[SerializeField]
		private LevelDifficultyTransformer difficultyTransformer;

		[SerializeField]
		private StringVariable difficulty;

		[SerializeField]
		private StringVariable detailedDifficulty;

		public override void Do(string value)
		{
		}
	}
}
