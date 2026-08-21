using UnityEngine;

namespace Crescive.LiveEvents.DynamicQuest
{
	public abstract class BaseDynamicQuestUISettings : ScriptableObject
	{
		public abstract DynamicQuestUIData GetUIDataById(string id);
	}
}
