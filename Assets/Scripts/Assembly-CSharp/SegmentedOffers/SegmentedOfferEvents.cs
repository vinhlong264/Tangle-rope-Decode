using UnityEngine.Purchasing;

namespace SegmentedOffers
{
	public class SegmentedOfferEvents
	{
		public struct IAPSuccessfull : IEvent
		{
			public Product Product;

			public IAPSuccessfull(Product product)
			{
				Product = null;
			}
		}

		public struct IAPSuccessfullDirectStore : IEvent
		{
			public string ProductID;

			public IAPSuccessfullDirectStore(string productID)
			{
				ProductID = null;
			}
		}
	}
}
