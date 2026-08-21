using System;

namespace Crescive.Transaction
{
	[Serializable]
	public class ResourceTransactionData : ICloneable
	{
		public string ResourceId;

		public int Amount;

		public bool Increase;

		public ResourceTransactionData()
		{
		}

		public ResourceTransactionData(ResourceTransactionData other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
