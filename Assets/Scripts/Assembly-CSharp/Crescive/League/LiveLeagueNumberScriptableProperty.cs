using Crescive.Scriptables;
using UnityEngine;

namespace Crescive.League
{
	[CreateAssetMenu(fileName = "Live League Number Scriptable Property", menuName = "Crescive/League/Property/Live League Number Scriptable Property")]
	public class LiveLeagueNumberScriptableProperty : IntScriptableProperty
	{
		[SerializeField]
		private PersistentLiveLeagueData persistentLiveLeagueData;

		protected override int GetValue()
		{
			return 0;
		}
	}
}
