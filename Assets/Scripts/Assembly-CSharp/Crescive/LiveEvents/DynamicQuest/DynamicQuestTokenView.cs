using UnityEngine;

namespace Crescive.LiveEvents.DynamicQuest
{
	public class DynamicQuestTokenView : TokenView
	{
		[SerializeField]
		private DynamicQuestSystem system;

		[SerializeField]
		private BaseDynamicQuestUISettings uiSettings;

		private void OnEnable()
		{
		}
	}
}
