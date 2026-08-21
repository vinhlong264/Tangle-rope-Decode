using PersistentSO;
using UnityEngine;

namespace Crescive.Transaction
{
	[CreateAssetMenu(menuName = "Crescive/Transaction/Persistent Transactions")]
	public class PersistentTransactions : PersistentListVariable<TransactionData>
	{
		public override TransactionData GetItemCopy(TransactionData item)
		{
			return null;
		}
	}
}
