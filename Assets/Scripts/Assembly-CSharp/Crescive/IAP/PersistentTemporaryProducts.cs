using System.Collections.Generic;
using PersistentSO;
using UnityEngine;

namespace Crescive.IAP
{
	[CreateAssetMenu(menuName = "Crescive/IAP/TemporaryProducts/PersistentTemporaryProducts")]
	public class PersistentTemporaryProducts : PersistentListVariable<TemporaryProductData>
	{
		public override TemporaryProductData GetItemCopy(TemporaryProductData item)
		{
			return null;
		}

		public bool ContainsItem(string id)
		{
			return false;
		}

		public TemporaryProductData GetItem(string id)
		{
			return null;
		}

		public bool HasItemExpired(string id)
		{
			return false;
		}

		public List<TemporaryProductData> GetExpiredItems()
		{
			return null;
		}

		public void RemoveItem(string id)
		{
		}

		public float GetClosestItemExpireRemainingSeconds()
		{
			return 0f;
		}

		public void AddOrUpdateProduct(TemporaryProductSettings settings)
		{
		}
	}
}
