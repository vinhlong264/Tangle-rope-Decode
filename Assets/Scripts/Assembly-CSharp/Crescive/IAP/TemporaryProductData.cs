using System;

namespace Crescive.IAP
{
	[Serializable]
	public class TemporaryProductData : ICloneable
	{
		public string Id;

		public string ClaimDate;

		public string ExpirationDate;

		public bool IsExpired => false;

		public TimeSpan RemainingTime => default(TimeSpan);

		public int RemainingSeconds => 0;

		private bool HasPassedExpirationDate()
		{
			return false;
		}

		public TemporaryProductData(TemporaryProductSettings settings)
		{
		}

		public TemporaryProductData(TemporaryProductData other)
		{
		}

		public void IncreaseExpirationDate(float seconds)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
