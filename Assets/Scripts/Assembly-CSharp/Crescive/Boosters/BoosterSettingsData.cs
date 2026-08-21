using System;
using System.Collections.Generic;
using Crescive.DataService;

namespace Crescive.Boosters
{
	[Serializable]
	public class BoosterSettingsData : IDataWithJson
	{
		public string Name;

		public string Description;

		public int Price;

		public int PurchaseCount;

		public int MinLevel;

		public List<JsonField> BoosterData;

		public List<JsonField> JsonData => null;

		public BoosterSettingsData(string name, string description, int price, int purchaseCount, int minLevel, List<JsonField> boosterData)
		{
		}

		public BoosterSettingsData(BoosterSettingsData other)
		{
		}
	}
}
