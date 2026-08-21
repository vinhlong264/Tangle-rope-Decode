using System;

namespace CresciveCore.Utils
{
	[Serializable]
	public class ItemGroupRequirementData
	{
		public bool Enabled;

		public int GroupPerItem;

		public ItemGroupRequirementData(ItemGroupRequirementData other)
		{
		}
	}
}
