using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Crescive.HelperTypes;
using Crescive.IAP;
using Crescive.MultiplierData;
using Crescive.Scheduler;
using UnityEngine;

namespace Crescive.LiveEvents.DynamicQuest
{
	[CreateAssetMenu(fileName = "Dynamic Quest System", menuName = "Crescive/Monetization Features/Dynamic Quest/System/Dynamic Quest System")]
	public class DynamicQuestSystem : ScriptableObject
	{
		[SerializeField]
		private DynamicQuestDataService service;

		[SerializeField]
		private PersistentDynamicQuestData saveData;

		[SerializeField]
		private SchedulerSystem scheduler;

		[SerializeField]
		private IAPStoreControllerChannel iapStoreControllerChannel;

		[SerializeField]
		private MultiplierProperty tokensMultiplier;

		[SerializeField]
		private IntSettableVariableReference collectedInLevelTokens;

		public PersistentDynamicQuestData SaveData => null;

		public string QuestId => null;

		public string SavedQuestId => null;

		public bool IsQuestLive => false;

		public IntSettableVariableReference CollectedInLevelTokens => null;

		public int CurrentStep => 0;

		public bool IsGoldenPassEnabled => false;

		public bool IsGoldenPassPurchased => false;

		public bool IsGoldenPassActive => false;

		public bool IsGoldenPassPurchasedAndNotActive => false;

		public bool IsGoldenPassLive => false;

		public int GoldenPassIntroPerStep => 0;

		public int GoldenPassIntroLastShownStep => 0;

		public int PendingTokensRaw => 0;

		public int PendingTokensMultiplied => 0;

		public bool HasPendingTokens => false;

		public float PendingMultiplierAmount => 0f;

		public bool HasPendingMultiplier => false;

		public float MultiplierAmount => 0f;

		public bool HasPendingSteps => false;

		public bool HasPassedSteps => false;

		public bool IsQuestStepsFinished => false;

		public event Action<StepsCompleteArgs> OnStepsCompleted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<int> OnStepCompleted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnQuestActivated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnQuestDeactivated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnGoldenPassActivated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<int> OnPendingTokensAdded
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private int GetRemainingTokensAfterPendingSteps()
		{
			return 0;
		}

		private void ResetSaveDataForEventActiveChange(string id, bool isActive)
		{
		}

		public DynamicQuestConfig GetQuestConfig(string id)
		{
			return null;
		}

		public DynamicQuestConfig GetCurrentQuestConfig()
		{
			return null;
		}

		public bool HasQuestWithId(string id)
		{
			return false;
		}

		public ScheduleData GetQuestSchedule()
		{
			return null;
		}

		public DateTime GetQuestStartDate()
		{
			return default(DateTime);
		}

		public DateTime GetQuestEndDate()
		{
			return default(DateTime);
		}

		public int GetTokensByRope()
		{
			return 0;
		}

		public DynamicQuestUIData GetQuestUIData(BaseDynamicQuestUISettings uiSettings)
		{
			return null;
		}

		public void SaveEventActivation(string id)
		{
		}

		public void SaveEventDeactivation(string id)
		{
		}

		public void AddPendingTokens(int tokens)
		{
		}

		public void SetPendingMultiplier(float multiplier)
		{
		}

		public void ClaimPendingTokens()
		{
		}

		public List<int> GetPendingSteps()
		{
			return null;
		}

		public List<string> GetStepsRewards(List<int> steps)
		{
			return null;
		}

		public List<string> GetStepsGoldenPassRewards(List<int> steps)
		{
			return null;
		}

		public List<string> GetStepsTotalRewards(List<int> steps)
		{
			return null;
		}

		public List<string> GetStepsRewardsBeforeClaim()
		{
			return null;
		}

		public List<string> GetStepsGoldenPassRewardsBeforeClaim()
		{
			return null;
		}

		public List<string> GetStepsTotalRewardsBeforeClaim()
		{
			return null;
		}

		public List<int> GetPassedSteps()
		{
			return null;
		}

		public List<string> GetGoldenPassRewardsBeforeClaim()
		{
			return null;
		}

		public List<string> GetPassedGoldenPassRewardsBeforeClaim()
		{
			return null;
		}

		public void SaveGoldenPassPurchased()
		{
		}

		public void ClaimGoldenPass()
		{
		}

		public void SaveGoldenPassIntroLastShownStepToNext()
		{
		}
	}
}
