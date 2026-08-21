using System;
using System.Collections.Generic;
using Crescive.IAP;
using Crescive.MultiplierData;
using Crescive.ResourceSystem;
using Crescive.Scheduler;
using Crescive.Shop;
using CresciveCore;
using UnityEngine;

namespace Crescive.LiveEvents.BattlePass
{
	[CreateAssetMenu(menuName = "Crescive/BattlePass/BattlePassSystem")]
	public class BattlePassSystem : ScriptableObject
	{
		public struct PendingTokensClaimedInfo
		{
			public int BaseTokensEarned;

			public float Multiplier;

			public BattlePassData PreviousData;
		}

		public struct ProductInfo
		{
			public Sprite? Sprite;

			public int? Amount;

			public int? XAmount;

			public float? Seconds;
		}

		private const string BattlePassDefaultScheduleId = "battle_pass_default";

		[SerializeField]
		private BattlePassDataService service;

		[SerializeField]
		private PersistentBattlePassData saveData;

		[SerializeField]
		private LevelSystem levelSystem;

		[SerializeField]
		[Header("Systems")]
		private SchedulerSystem scheduler;

		[SerializeField]
		private IAPStoreControllerChannel iapStoreControllerChannel;

		[SerializeField]
		private ResourceChannel coinResourceChannel;

		[SerializeField]
		private MultiplierProperty tokensMultiplier;

		[SerializeField]
		private HeartResourceGeneratorSelector heartDataSelector;

		[SerializeField]
		private ResourceChannel heartChannel;

		[SerializeField]
		[Header("Data Services")]
		private ShopProductsAssetData shopProductsAssetData;

		[SerializeField]
		private IAPDataService iapDataService;

		[Header("Analytics")]
		[SerializeField]
		private CresciveEventSender eventSender;

		public BattlePassDataService Service => null;

		public PersistentBattlePassData SaveData => null;

		public string? CurrentPassId => null;

		public bool IsPassPendingLive => false;

		public int CurrentStep => 0;

		public int PendingTokensRaw => 0;

		public int PendingTokensMultiplied => 0;

		public float PendingMultiplierAmount => 0f;

		public float MultiplierAmount => 0f;

		public bool IsGoldenTicketPurchased => false;

		public void HandleDataMigration()
		{
		}

		public BattlePassConfig? GetCurrentPassConfig()
		{
			return null;
		}

		public ScheduleData? GetCurrentPassSchedule()
		{
			return null;
		}

		public DateTime? GetCurrentPassStartDate()
		{
			return null;
		}

		public DateTime? GetCurrentPassEndDate()
		{
			return null;
		}

		public void StartPass()
		{
		}

		private void SendBattlePassActivatedEvent()
		{
		}

		public PendingTokensClaimedInfo? ClaimPendingTokens()
		{
			return null;
		}

		public bool BonusCaseCompleted()
		{
			return false;
		}

		private void SendBattlePassTierUnlockedEvent(int unlockedTier)
		{
		}

		public int StepAndTokenToTotalTokens(int stepIndex, int tokens)
		{
			return 0;
		}

		public (int, int) TotalTokensToStepAndToken(int totalTokens)
		{
			return default((int, int));
		}

		public void ClaimStep(int step, bool isGolden)
		{
		}

		public bool IsStepUnlocked(int step)
		{
			return false;
		}

		public bool IsCurrentStep(int step)
		{
			return false;
		}

		public bool HasClaimableStep(int step, bool isGolden)
		{
			return false;
		}

		public string? GetProductId(int stepIndex, bool isGolden)
		{
			return null;
		}

		public int GetAccumulatedBonusCase()
		{
			return 0;
		}

		public int GetTargetBonusCase()
		{
			return 0;
		}

		public List<(int, bool)> GetClaimableSteps()
		{
			return null;
		}

		public List<string> GetClaimableStepsProductIds()
		{
			return null;
		}

		public void ClaimBonusChest()
		{
		}

		public bool CanClaimBonusChest()
		{
			return false;
		}

		public void ClaimAllClaimableSteps()
		{
		}

		public void SaveGoldenTicketPurchased()
		{
		}

		private void SendBattlePassGoldenTicketActivatedEvent(string source)
		{
		}

		private void EarnHeartsGoldenTicket()
		{
		}

		public int CalculateTokenEarnAmount()
		{
			return 0;
		}

		public bool WouldTokensIncreaseStep()
		{
			return false;
		}

		public void HandlePendingTokenEarn()
		{
		}

		public void AddToke(int amount)
		{
		}

		public bool IsStepsFinished()
		{
			return false;
		}

		public (int, int, int, int) GetBonusChestInfo()
		{
			return default((int, int, int, int));
		}

		private void SendBattlePassBankCompletedEvent()
		{
		}

		private void SendBattlePassBankClaimedEvent(int amount)
		{
		}

		public void UpdateLastOpenedStep()
		{
		}

		public ProductInfo? GetProductInfo(string productId)
		{
			return null;
		}

		private ScheduleSaveData? GetScheduleSaveData()
		{
			return null;
		}

		private void HandleActivationCountMigration()
		{
		}

		private void HandleOldPlayersIsTutorialFinished()
		{
		}

		public void RefreshScheduleLogic()
		{
		}

		public void FinishedToInactive()
		{
		}

		private void SendBattlePassDeactivatedEvent()
		{
		}

		private void PrepareNewPass()
		{
		}

		public bool HasClaimedStep(int stepIndex, bool isGolden)
		{
			return false;
		}

		private void SendBattlePassRewardClaimedEvent(int tier, string rewardType)
		{
		}
	}
}
