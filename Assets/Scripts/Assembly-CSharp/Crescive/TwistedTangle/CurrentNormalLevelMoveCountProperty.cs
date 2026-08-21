using Crescive.Scriptables;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class CurrentNormalLevelMoveCountProperty : IntScriptableProperty
	{
		[SerializeField]
		private LevelsMoveCountSettingsService levelsMoveCountSettingsService;

		protected override int GetValue()
		{
			return 0;
		}
	}
}
