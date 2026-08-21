using System.Collections.Generic;
using Crescive.Scheduler;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.LadderOffer
{
	[CreateAssetMenu(fileName = "Ladder Offer System", menuName = "Crescive/Monetization Features/Ladder Offer/System/Ladder Offer System")]
	public class LadderOfferSystem : ScriptableObject
	{
		[SerializeField]
		private LadderOffersDataService dataService;

		[SerializeField]
		private PersistentLadderOffersData saveData;

		[SerializeField]
		private LadderOffersSettings offersSettings;

		[SerializeField]
		private SchedulerSystem schedulerSystem;

		public UnityEvent<LadderOfferShownEventArgs> OnShown;

		public UnityEvent<LadderOfferItemClaimedEventArgs> OnItemClaimed;

		public LadderOffersDataService DataService => null;

		public PersistentLadderOffersData SaveData => null;

		public LadderOffersSettings OffersSettings => null;

		public SchedulerSystem SchedulerSystem => null;

		public void TriggerShown(LadderOfferData data, bool forceShown)
		{
		}

		public void TriggerItemClaimed(LadderOfferData data, LadderOfferItemData itemData, int step)
		{
		}

		public List<string> GetLadderOfferIds(bool includeEmpty = false)
		{
			return null;
		}

		public LadderOfferData GetLadderOfferData(string id)
		{
			return null;
		}

		public LadderOfferData GetLadderOfferDataByItemId(string itemId)
		{
			return null;
		}

		public LadderOfferSaveData GetLadderOfferSaveData(string id)
		{
			return null;
		}

		public LadderOfferSettings GetLadderOfferSettingsById(string id)
		{
			return null;
		}

		public bool IsLadderOfferActive(string id)
		{
			return false;
		}

		public void SetLadderOfferSaveData(string id, LadderOfferSaveData value)
		{
		}

		public void ResetLadderOfferSaveData(string id)
		{
		}

		public void IncreaseCurrentIndex(string id)
		{
		}

		public bool IsLadderOfferAllClaimed(string ladderOfferId)
		{
			return false;
		}
	}
}
