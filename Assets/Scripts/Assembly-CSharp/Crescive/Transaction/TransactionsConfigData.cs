using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Transaction
{
	[CreateAssetMenu(menuName = "Crescive/Transaction/Transactions Config Data")]
	public class TransactionsConfigData : ScriptableObject
	{
		[SerializeField]
		private List<string> types;

		[SerializeField]
		private List<string> sources;

		public List<string> Types => null;

		public List<string> Sources => null;

		public static TransactionsConfigData Instance => null;
	}
}
