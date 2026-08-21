using System;
using System.Collections.Generic;
using Crescive.DataService;

namespace Crescive.PowerUps
{
	[Serializable]
	public class PowerUpSettingsData : IDataWithJson
	{
		public string Name;

		public string Description;

		public string TutorialText;

		public int Price;

		public int PurchaseCount;

		public int MinLevel;

		public List<JsonField> PowerUpData;

		public List<JsonField> JsonData => null;

		public PowerUpSettingsData(string name, string description, string tutorialText, int price, int purchaseCount, int minLevel, List<JsonField> powerUpData)
		{
		}

		public PowerUpSettingsData(PowerUpSettingsData other)
		{
		}
	}
}
