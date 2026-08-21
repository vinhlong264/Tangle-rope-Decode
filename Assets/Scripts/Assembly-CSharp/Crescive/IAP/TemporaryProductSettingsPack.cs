using System;
using System.Collections.Generic;
using Crescive.DataService;
using UnityEngine;

namespace Crescive.IAP
{
	[Serializable]
	public class TemporaryProductSettingsPack : ICloneable, IMergeable<TemporaryProductSettingsPack>
	{
		[SerializeField]
		private string productPackId;

		[SerializeField]
		private List<TemporaryProductSettings> allSettings;

		public string ProductPackId => null;

		public List<TemporaryProductSettings> AllSettings => null;

		public TemporaryProductSettingsPack(TemporaryProductSettingsPack other)
		{
		}

		public object Clone()
		{
			return null;
		}

		public void Merge(TemporaryProductSettingsPack other)
		{
		}

		public bool CanMergeWith(TemporaryProductSettingsPack other)
		{
			return false;
		}

		public bool HasSettings(string productId)
		{
			return false;
		}

		public bool HasSettingsForOriginalProduct(string originalId)
		{
			return false;
		}

		public TemporaryProductSettings GetSettings(string productId)
		{
			return null;
		}

		public TemporaryProductSettings GetSettingsForOriginalProduct(string originalId)
		{
			return null;
		}
	}
}
