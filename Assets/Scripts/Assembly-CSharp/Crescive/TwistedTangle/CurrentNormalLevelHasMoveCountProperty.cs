using Crescive.Scriptables;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	[CreateAssetMenu(fileName = "CurerntNormaLevelHasMoveCountProperty", menuName = "GameData/Gameplay/MoveCount/Property/CurerntNormaLevelHasMoveCountProperty")]
	public class CurrentNormalLevelHasMoveCountProperty : BoolScriptableProperty
	{
		[SerializeField]
		private LevelsMoveCountSettingsService moveCountService;

		protected override bool GetValue()
		{
			return false;
		}
	}
}
