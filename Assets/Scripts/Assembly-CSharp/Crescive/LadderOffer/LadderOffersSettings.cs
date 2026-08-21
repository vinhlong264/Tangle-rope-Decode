using System;
using System.Collections.Generic;
using UnityEngine;

namespace Crescive.LadderOffer
{
	[CreateAssetMenu(fileName = "Ladder Offer View Settings", menuName = "Crescive/Monetization Features/Ladder Offer/UI/Ladder Offer View Settings")]
	public class LadderOffersSettings : ScriptableObject
	{
		[Serializable]
		public class SettingsById
		{
			public string Id;

			public LadderOfferSettings Settings;
		}

		[SerializeField]
		private List<SettingsById> settingsByIds;

		public LadderOfferSettings GetSettingsById(string id)
		{
			return null;
		}
	}
}
