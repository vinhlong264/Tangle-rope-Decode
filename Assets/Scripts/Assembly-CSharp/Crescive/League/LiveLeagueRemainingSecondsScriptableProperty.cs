using Crescive.Scriptables;
using UnityEngine;

namespace Crescive.League
{
	[CreateAssetMenu(fileName = "Live League Remaining Seconds Scriptable Property", menuName = "Crescive/League/Property/Live League Remaining Seconds Scriptable Property")]
	public class LiveLeagueRemainingSecondsScriptableProperty : IntScriptableProperty
	{
		[SerializeField]
		private PersistentLiveLeagueData persistentLiveLeagueData;

		protected override int GetValue()
		{
			return 0;
		}
	}
}
