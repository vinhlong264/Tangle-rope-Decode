using System;
using System.Collections.Generic;
using Crescive.DataService;
using UnityEngine;

namespace Crescive.IAP
{
	[Serializable]
	public class ConditionalIdSettingsPack : ICloneable, IMergeable<ConditionalIdSettingsPack>
	{
		[SerializeField]
		private string productPackId;

		[SerializeField]
		private List<ConditionalIdSettings> allSettings;

		public ConditionalIdSettingsPack(ConditionalIdSettingsPack other)
		{
		}

		public object Clone()
		{
			return null;
		}

		public bool HasSettings(string productId)
		{
			return false;
		}

		public ConditionalIdSettings GetSettings(string productId)
		{
			return null;
		}

		public void Merge(ConditionalIdSettingsPack other)
		{
		}

		public bool CanMergeWith(ConditionalIdSettingsPack other)
		{
			return false;
		}
	}
}
