using System.Collections.Generic;
using Crescive.DataService;
using CresciveCore;
using UnityAtoms;
using UnityEngine;

namespace Crescive.PopUps
{
	[CreateAssetMenu(fileName = "OfferPopUpLevelSettingsService", menuName = "GameData/OfferPopUp/OfferPopUpLevelSettingsService")]
	public class OfferPopUpLevelSettingsDataService : DataReadService<OfferPopUpLevelSettingsData>
	{
		[SerializeField]
		private LevelSystem levelSystem;

		[SerializeField]
		private List<AtomCondition> popupAvailableConditions;

		public bool IsPopUpAvailable()
		{
			return false;
		}

		public bool IsRequiredLevelPassedForBossLevelNumber(int bossLevelNumber, out int requiredLevel)
		{
			requiredLevel = default(int);
			return false;
		}

		public bool IsRequiredLevelPassedForBossLevelNumberWithCustomStartLevel(int bossLevelNumber, int startLevel, out int requiredLevel, bool checkIfReached = false)
		{
			requiredLevel = default(int);
			return false;
		}

		public int GetNextPopupLevel()
		{
			return 0;
		}

		protected override OfferPopUpLevelSettingsData GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(OfferPopUpLevelSettingsData plainData)
		{
			return false;
		}
	}
}
