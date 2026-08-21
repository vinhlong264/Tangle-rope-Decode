using System;
using System.Collections.Generic;
using UnityEngine;

namespace Crescive.IAP
{
	[Serializable]
	public class LimitedOfferSettings : ICloneable
	{
		public bool Enabled;

		[Header("Offer")]
		public string OfferId;

		public bool HasInfiniteDuration;

		public float OfferDurationHours;

		public bool HasInfiniteOfferCount;

		public int MaxOfferCount;

		[Header("Product")]
		public string ProductId;

		private List<string> ProductIds => null;

		public LimitedOfferSettings()
		{
		}

		public LimitedOfferSettings(LimitedOfferSettings other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
