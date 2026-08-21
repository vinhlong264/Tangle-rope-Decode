using Crescive.Scriptables;
using UnityEngine;

namespace Crescive.LiveEvents.DynamicQuest
{
	[CreateAssetMenu(fileName = "Dynamic Quest Pending Tokens Property", menuName = "Crescive/Monetization Features/Dynamic Quest/Core/Property/Dynamic Quest Pending Tokens Property")]
	public class DynamicQuestPendingTokensProperty : IntScriptableProperty
	{
		[SerializeField]
		private DynamicQuestSystem system;

		[SerializeField]
		private bool useRaw;

		protected override int GetValue()
		{
			return 0;
		}
	}
}
