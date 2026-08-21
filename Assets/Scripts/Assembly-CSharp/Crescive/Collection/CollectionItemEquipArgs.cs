using System;

namespace Crescive.Collection
{
	[Serializable]
	public struct CollectionItemEquipArgs
	{
		public string ItemId;

		public string OldItemId;

		public CollectionItemSystem ItemSystem;

		public bool IsIdChanged => false;

		public CollectionItemEquipArgs(string itemId, string oldItemId, CollectionItemSystem itemSystem)
		{
			ItemId = null;
			OldItemId = null;
			ItemSystem = null;
		}
	}
}
