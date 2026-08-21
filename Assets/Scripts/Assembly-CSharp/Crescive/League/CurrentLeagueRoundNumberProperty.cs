using Crescive.Scriptables;
using UnityEngine;

namespace Crescive.League
{
	[CreateAssetMenu(fileName = "Current League Round Number Property", menuName = "Crescive/League/Property/Current League Round Number Property")]
	public class CurrentLeagueRoundNumberProperty : IntScriptableProperty
	{
		[SerializeField]
		private PersistentLiveLeagueData persistentLiveLeagueData;

		protected override int GetValue()
		{
			return 0;
		}
	}
}
