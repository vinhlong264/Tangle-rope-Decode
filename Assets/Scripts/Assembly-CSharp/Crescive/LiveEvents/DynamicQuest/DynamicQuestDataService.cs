using Crescive.DataService;
using UnityEngine;

namespace Crescive.LiveEvents.DynamicQuest
{
	[CreateAssetMenu(fileName = "Dynamic Quest Data Service", menuName = "Crescive/Monetization Features/Dynamic Quest/Service/Dynamic Quest Data Service")]
	public class DynamicQuestDataService : DataReadService<DynamicQuestSettings>
	{
		protected override DynamicQuestSettings GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(DynamicQuestSettings plainData)
		{
			return false;
		}

		protected override DynamicQuestSettings PreProcessData(DynamicQuestSettings plainData)
		{
			return null;
		}

		public void AddTargetTokensFromClipboard(string id)
		{
		}
	}
}
