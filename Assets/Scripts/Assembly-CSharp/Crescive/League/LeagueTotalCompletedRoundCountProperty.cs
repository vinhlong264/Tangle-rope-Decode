using Crescive.Scriptables;
using UnityEngine;

namespace Crescive.League
{
	[CreateAssetMenu(fileName = "League Total Completed Round Count Property", menuName = "Crescive/League/Property/League Total Completed Round Count Property")]
	public class LeagueTotalCompletedRoundCountProperty : IntScriptableProperty
	{
		[SerializeField]
		private PersistentLiveLeagueData persistentLiveLeagueData;

		protected override int GetValue()
		{
			return 0;
		}
	}
}
