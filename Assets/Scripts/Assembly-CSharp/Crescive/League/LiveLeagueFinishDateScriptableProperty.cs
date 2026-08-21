using Crescive.Scriptables;
using UnityEngine;

namespace Crescive.League
{
	[CreateAssetMenu(fileName = "Live League Finish Date Scriptable Property", menuName = "Crescive/League/Property/Live League Finish Date Scriptable Property")]
	public class LiveLeagueFinishDateScriptableProperty : StringScriptableProperty
	{
		[SerializeField]
		private PersistentLiveLeagueData persistentLiveLeagueData;

		protected override string GetValue()
		{
			return null;
		}
	}
}
