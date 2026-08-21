using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Transaction
{
	[CreateAssetMenu(menuName = "Crescive/Transaction/Transaction System")]
	public class TransactionSystem : ScriptableObject
	{
		[SerializeField]
		private PersistentTransactions savedTxs;

		public void AddTx(TransactionData tx)
		{
		}

		public void AddTxs(List<TransactionData> txs)
		{
		}

		public void RemoveTx(TransactionData tx)
		{
		}

		public void RemoveTxs(List<TransactionData> txs)
		{
		}

		public void UpdateTx(TransactionData tx)
		{
		}

		public T ResolveTxData<T>(TransactionData data)
		{
			return default(T);
		}

		public bool HasTxType(string type)
		{
			return false;
		}

		public List<TransactionData> GetTxs(string type)
		{
			return null;
		}

		public List<TransactionData> GetTxs(string type, string source)
		{
			return null;
		}

		public List<TransactionData> GetTxs(string type, List<string> sources)
		{
			return null;
		}

		public List<T> GetResolvedTxsData<T>(List<TransactionData> txs)
		{
			return null;
		}

		public List<T> GetResolvedTxsData<T>(string type)
		{
			return null;
		}

		public List<T> GetResolvedTxsData<T>(string type, string source)
		{
			return null;
		}

		public List<T> GetResolvedTxsData<T>(string type, List<string> sources)
		{
			return null;
		}
	}
}
