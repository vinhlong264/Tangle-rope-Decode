using System;
using System.Collections.Generic;
using UnityEngine;

namespace Crescive.IAP
{
	[Serializable]
	public class TemporaryProductSettings : ICloneable
	{
		public string Id;

		public string OriginalSaveProductId;

		[SerializeField]
		private float ExpirationHours;

		[SerializeField]
		private float ExpirationMinutes;

		[SerializeField]
		private float ExpirationSeconds;

		public float TotalExpirationTimeInSeconds => 0f;

		private List<string> Ids => null;

		public TemporaryProductSettings(string id, string originalSaveProductId, float expirationHours, float expirationMinutes, float expirationSeconds)
		{
		}

		public TemporaryProductSettings(TemporaryProductSettings other)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
