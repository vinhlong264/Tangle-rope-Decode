using System.Collections.Generic;
using Crescive.HelperTypes;
using Crescive.Navigation;
using Crescive.ResourceSystem;
using CresciveCore;
using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Boosters
{
	[CreateAssetMenu(fileName = "Booster System", menuName = "Crescive/Boosters/Core/Booster System")]
	public class BoosterSystem : ScriptableObject
	{
		[SerializeField]
		private LevelSystem levelSystem;

		[SerializeField]
		private List<BoosterGroup> boosterGroups;

		[SerializeField]
		private PersistentBoolVariable didClaimFirstTimeThisLevel;

		[SerializeField]
		private BoolVariable boostersEnabled;

		[SerializeField]
		private NavigationChannel popupsNavigationChannel;

		[SerializeField]
		private StringVariableReference tutorialPopupId;

		[SerializeField]
		private List<BoolVariableReference> anyBoosterClaimPopupConditions;

		[SerializeField]
		private List<BoolVariableReference> anyBoosterButtonClickableConditions;

		[SerializeField]
		private List<BoosterChannel> currentBoosters;

		public UnityEvent<BoosterChannel> OnRequested;

		public UnityEvent<BoosterChannel> OnStarted;

		public UnityEvent<BoosterChannel> OnCanceled;

		public UnityEvent<BoosterChannel> OnPerformed;

		public UnityEvent<BoosterChannel> OnFinished;

		public UnityEvent<BoosterChannel> OnCanceledOrFinished;

		public UnityEvent<BoosterChannel> OnResourceNotEnough;

		public UnityEvent<BoosterChannel, ResourceValueEventArgs> OnBoosterPurchasedWithResource;

		public bool Enabled => false;

		public List<BoosterChannel> Boosters => null;

		public List<BoosterChannel> AvailableBoosters => null;

		public List<string> AvailableBoosterIds => null;

		public List<BoosterChannel> CurrentBoosters => null;

		public PersistentBoolVariable DidClaimFirstTimeThisLevel => null;

		public void ClearBoosters()
		{
		}

		public void AddCurrentBooster(BoosterChannel boosterChannel)
		{
		}

		public void RemoveCurrentBooster(BoosterChannel boosterChannel)
		{
		}

		public bool IsBoosterInUseExcept(BoosterChannel boosterChannel)
		{
			return false;
		}

		public List<BoosterChannel> GetVisibleAvailableBoosters()
		{
			return null;
		}

		public BoosterChannel GetBoosterWithId(string boosterId)
		{
			return null;
		}

		public bool CanShowClaimPopupForAnyBooster()
		{
			return false;
		}

		public bool CanClaimAnyBoosterNow()
		{
			return false;
		}

		public bool CanClaimBoosterNow(BoosterChannel boosterChannel)
		{
			return false;
		}

		public bool CanClaimBoosterFirstTimeFinalCheck(BoosterChannel boosterChannel)
		{
			return false;
		}

		public void ActivateTutorialForBooster(BoosterChannel boosterChannel)
		{
		}

		public bool AllBoostersHaveState(BoosterState boosterState, List<BoosterChannel> excludedBoosters)
		{
			return false;
		}

		public bool AnyBoosterHaveState(BoosterState boosterState, List<BoosterChannel> excludedBoosters)
		{
			return false;
		}

		public bool AllBoostersNotHaveState(BoosterState boosterState)
		{
			return false;
		}

		public bool AreAllBoostersBeforeThisUnlocked(BoosterChannel boosterChannel)
		{
			return false;
		}

		public bool IsBoosterButtonClickable(BoosterChannel boosterChannel)
		{
			return false;
		}

		public int GetMinLevelForBooster(BoosterChannel boosterChannel)
		{
			return 0;
		}
	}
}
