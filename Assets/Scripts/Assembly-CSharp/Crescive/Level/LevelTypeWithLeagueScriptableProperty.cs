using Crescive.Scriptables;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Level
{
	[CreateAssetMenu(fileName = "Level Type With League", menuName = "Crescive/Levels/Level Type With League")]
	public class LevelTypeWithLeagueScriptableProperty : StringScriptableProperty
	{
		[SerializeField]
		private StringVariable levelType;

		[SerializeField]
		private AtomCondition isCurrentLevelNormal;

		[SerializeField]
		private AtomCondition isPlayingLeague;

		[SerializeField]
		private StringConstant leagueLevelType;

		protected override string GetValue()
		{
			return null;
		}
	}
}
