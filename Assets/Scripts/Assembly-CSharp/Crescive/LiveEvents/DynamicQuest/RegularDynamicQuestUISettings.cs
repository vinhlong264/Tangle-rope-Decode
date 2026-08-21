using System.Collections.Generic;
using UnityEngine;

namespace Crescive.LiveEvents.DynamicQuest
{
	[CreateAssetMenu(fileName = "Regular Dynamic Quest UI Settings", menuName = "Crescive/Monetization Features/Dynamic Quest/UI/Settings/Regular Dynamic Quest UI Settings")]
	public class RegularDynamicQuestUISettings : BaseDynamicQuestUISettings
	{
		[SerializeField]
		private DynamicQuestUIData defaultUIData;

		[SerializeField]
		private List<DynamicQuestUIDataById> uiDatasById;

		public override DynamicQuestUIData GetUIDataById(string id)
		{
			return null;
		}
	}
}
