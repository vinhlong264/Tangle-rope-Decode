using PersistentSO;
using UnityEngine;

namespace Crescive.LiveEvents.DynamicQuest
{
	[CreateAssetMenu(menuName = "Crescive/Monetization Features/Live Events/Dynamic Quest/Persistent")]
	public class PersistentDynamicQuestData : PersistentVariable<DynamicQuestData>
	{
		public override DynamicQuestData GetCopy(DynamicQuestData value)
		{
			return null;
		}
	}
}
