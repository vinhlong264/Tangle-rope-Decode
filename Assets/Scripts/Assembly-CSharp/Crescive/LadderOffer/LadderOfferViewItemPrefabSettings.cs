using System;
using System.Collections.Generic;
using UnityEngine;

namespace Crescive.LadderOffer
{
	[CreateAssetMenu(fileName = "Ladder Offer View Item Prefab Settings", menuName = "Crescive/Monetization Features/Ladder Offer/UI/Ladder Offer View Item Prefab Settings")]
	public class LadderOfferViewItemPrefabSettings : ScriptableObject
	{
		[Serializable]
		public class ItemViewByType
		{
			public string Type;

			public LadderOfferItemView ItemViewPrefab;

			public List<string> ItemTypes => null;
		}

		[SerializeField]
		private List<ItemViewByType> itemViewsPrefabs;

		public LadderOfferItemView GetViewPrefabByType(string itemType)
		{
			return null;
		}
	}
}
