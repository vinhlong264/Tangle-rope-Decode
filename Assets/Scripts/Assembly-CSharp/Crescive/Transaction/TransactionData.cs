using System;
using System.Collections.Generic;

namespace Crescive.Transaction
{
	[Serializable]
	public class TransactionData : ICloneable
	{
		public string Type;

		public string Source;

		public string Category;

		public TxPerformStrategy Strategy;

		public string Id;

		public string DataJson;

		public string Date;

		private List<string> Types => null;

		private List<string> Sources => null;

		private List<string> Categories => null;

		public TransactionData()
		{
		}

		public TransactionData(TransactionData data)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
