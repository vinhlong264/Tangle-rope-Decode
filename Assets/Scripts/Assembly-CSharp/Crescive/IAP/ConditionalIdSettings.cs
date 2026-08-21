using System;
using System.Collections.Generic;

namespace Crescive.IAP
{
	[Serializable]
	public class ConditionalIdSettings : ICloneable
	{
		public string Id;

		public float MinPaymentAmount;

		public float MaxPaymentAmount;

		public string DependentRemoteConfigKey;

		public bool DependentValue;

		public bool HasRemoteDependency => false;

		private List<string> AllIds => null;

		public ConditionalIdSettings()
		{
		}

		public ConditionalIdSettings(ConditionalIdSettings other)
		{
		}

		public object Clone()
		{
			return null;
		}

		public bool IsPaymentAmountValid(float paymentAmount)
		{
			return false;
		}
	}
}
