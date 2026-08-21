using Crescive.League;
using Crescive.Scriptables;
using UnityEngine;

namespace Crescive.TwistedTangle.SpecialEditor
{
	public class ActualLevelOpener : MonoBehaviour
	{
		[SerializeField]
		private IntScriptableAction loadNormalLevelWithNumberAction;

		[SerializeField]
		private LeagueTotalCompletedRoundCountProperty leagueTotalCompletedRoundCountProperty;

		public void OpenActualLevel(int levelToOpen)
		{
		}
	}
}
