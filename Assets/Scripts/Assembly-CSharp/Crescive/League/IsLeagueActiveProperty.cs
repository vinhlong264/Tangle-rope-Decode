using Crescive.Scriptables;
using UnityEngine;

namespace Crescive.League
{
	[CreateAssetMenu(fileName = "Is League Active Property", menuName = "Crescive/League/Property/Is League Active Property")]
	public class IsLeagueActiveProperty : BoolScriptableProperty
	{
		[SerializeField]
		private PersistentLiveLeagueData savedLiveLeagueData;

		protected override bool GetValue()
		{
			return false;
		}
	}
}
