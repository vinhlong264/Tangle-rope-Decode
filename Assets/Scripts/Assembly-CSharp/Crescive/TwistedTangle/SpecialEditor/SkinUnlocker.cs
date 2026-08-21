using System.Collections.Generic;
using Crescive.Collection;
using PersistentSO;
using UnityEngine;

namespace Crescive.TwistedTangle.SpecialEditor
{
	public class SkinUnlocker : MonoBehaviour
	{
		[SerializeField]
		private PersistentStringListVariable unlockedShopItems;

		[SerializeField]
		private List<CollectionItemSystem> shopItemSystems;

		private void UnlockAllShopItemListService()
		{
		}

		private void UnlockShopItemListService(CollectionItemsService shopItemListService)
		{
		}

		public void UnlockEverything()
		{
		}

		public void ResetUnlockData()
		{
		}
	}
}
