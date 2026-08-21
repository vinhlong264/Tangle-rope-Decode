using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Transaction
{
	public abstract class BaseTransactionPerformer<T> : MonoBehaviour
	{
		[SerializeField]
		private string type;

		[SerializeField]
		private List<string> sources;

		[SerializeField]
		private TransactionSystem system;

		private List<string> Types => null;

		private List<string> Sources => null;

		private void Start()
		{
		}

		protected List<T> GetAvailableResolvedTxs()
		{
			return null;
		}

		protected List<TransactionData> GetAvailableTxs()
		{
			return null;
		}

		private void TryPerformTxs(TxPerformStrategy strategy)
		{
		}

		protected abstract void PerformTxsInternal(List<T> txs);
	}
}
