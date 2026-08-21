using System.Runtime.InteropServices;

namespace Systems.MiniShopSpecialOffers
{
	public class MiniShopSpecialOffersEvents
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		public struct OnMiniShopOffersEnabled : IEvent
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		public struct OnMiniShopOffersDisabled : IEvent
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		public struct OnMiniShopOffersRefreshed : IEvent
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		public struct OnMiniShopOffersTimeExpired : IEvent
		{
		}

		public struct OnMiniShopOffersPurchased : IEvent
		{
			public string productID;

			public int productIndex;

			public OnMiniShopOffersPurchased(string productID, int productIndex)
			{
				this.productID = null;
				this.productIndex = 0;
			}
		}
	}
}
