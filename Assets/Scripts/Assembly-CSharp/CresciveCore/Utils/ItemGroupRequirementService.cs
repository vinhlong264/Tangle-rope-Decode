using Crescive.DataService;
using UnityEngine;

namespace CresciveCore.Utils
{
	[CreateAssetMenu(fileName = "ItemGroupRequirementService", menuName = "Crescive/Utils/Data Services/ItemGroupRequirementService")]
	public class ItemGroupRequirementService : DataReadService<ItemGroupRequirementData>
	{
		protected override ItemGroupRequirementData GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(ItemGroupRequirementData plainData)
		{
			return false;
		}
	}
}
