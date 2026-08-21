using System.Collections.Generic;
using Crescive.IAP;
using UnityEngine;

namespace Crescive.Transaction
{
	public class IAPTransactionPerformer : BaseTransactionPerformer<IAPTransactionData>
	{
		[SerializeField]
		private IAPStoreControllerChannel storeChannel;

		protected override void PerformTxsInternal(List<IAPTransactionData> txs)
		{
		}
	}
}
