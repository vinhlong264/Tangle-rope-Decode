using System.Collections.Generic;
using Crescive.DataService;
using PersistentSO;
using UnityEngine;

namespace Crescive.IAP
{
	[CreateAssetMenu(menuName = "Crescive/IAP/Data Service/IAP Data Service", fileName = "IAP Data Service")]
	public class IAPDataService : CompositeDataReadService<IAPData>
	{
		[SerializeField]
		[Space(5f)]
		private IAPStoreControllerChannel storeController;

		[SerializeField]
		private CresciveBaseRemoteConfigSource configSource;

		[SerializeField]
		private PersistentUserPayments savedPayments;

		[SerializeField]
		private PersistentStringListVariable fakeReceipts;

		[SerializeField]
		private List<IdDisablerConditionData> idDisableData;

		[SerializeField]
		private List<IdDisablerConditionData> idHideInShopData;

		public IIAPStoreController StoreController => null;

		public PersistentStringListVariable FakeReceipts => null;

		public CresciveBaseRemoteConfigSource ConfigSource => null;

		public PersistentUserPayments SavedPayments => null;

		public List<string> AllIds => null;

		protected override IAPData GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(IAPData plainData)
		{
			return false;
		}

		public List<string> GetBundleProductIds(string productId)
		{
			return null;
		}

		public bool IsIdDisabled(string id)
		{
			return false;
		}

		public bool IsIdHiddenInShop(string id)
		{
			return false;
		}

		private void PrintAndCopyAllCatalogProductIds()
		{
		}

		public static IAPDataService GetInstance()
		{
			return null;
		}
	}
}
