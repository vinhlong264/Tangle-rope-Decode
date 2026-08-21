using System;
using System.Collections.Generic;
using Crescive.HelperTypes;
using Crescive.ResourceSystem;
using CresciveCore;
using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Boosters
{
	[CreateAssetMenu(fileName = "Booster Channel", menuName = "Crescive/Boosters/Channels/Booster Channel")]
	public class BoosterChannel : ScriptableObject
	{
		[SerializeField]
		private BoosterState currentState;

		[SerializeField]
		private LevelSystem levelSystem;

		[Space]
		[SerializeField]
		private ResourceChannel resourceChannel;

		[SerializeField]
		private BoosterSettingsDataService settings;

		[SerializeField]
		private BoosterUIData uiData;

		[Space]
		[SerializeField]
		private List<BoolVariableReference> boosterAvailableConditions;

		[SerializeField]
		private List<BoolVariableReference> buttonVisibleConditions;

		[SerializeField]
		private List<BoolVariable> buttonActiveConditions;

		[SerializeField]
		private List<BoolVariableReference> buttonClickableConditions;

		[SerializeField]
		private PersistentBoolVariable didClaimFirstTime;

		public UnityEvent<BoosterChannel> OnRequested;

		public UnityEvent<BoosterChannel> OnStarted;

		public UnityEvent<BoosterChannel> OnCanceled;

		public UnityEvent<BoosterChannel> OnPerformed;

		public UnityEvent<BoosterChannel> OnFinished;

		public UnityEvent<BoosterChannel> OnCanceledOrFinished;

		public UnityEvent<BoosterChannel, ResourceValueEventArgs> OnBoosterPurchasedWithResource;

		public UnityEvent<BoosterChannel> OnResourceNotEnough;

		public string Id => null;

		public BoosterState CurrentState => default(BoosterState);

		public bool IsStateRequested => false;

		public bool IsStateStarted => false;

		public bool IsStatePerformed => false;

		public bool IsStateIdle => false;

		public bool IsInUse => false;

		public bool IsRunning => false;

		public ResourceChannel Resource => null;

		public BoosterSettingsDataService Settings => null;

		public BoosterUIData UIData => null;

		public PersistentBoolVariable DidClaimFirstTime => null;

		public bool IsUnlocked => false;

		public bool HasResource => false;

		public bool IsBoosterAvailable => false;

		public bool IsButtonVisible => false;

		public bool IsButtonActive => false;

		public bool IsButtonClickable => false;

		public void SubscribeToButtonActiveConditions(Action<bool> action)
		{
		}

		public void UnsubscribeFromButtonActiveConditions(Action<bool> action)
		{
		}

		private void SetState(BoosterState state)
		{
		}

		public void TryRequestBooster()
		{
		}

		public void RequestBooster()
		{
		}

		public void StartBooster(bool spendResource = true)
		{
		}

		public void CancelBooster()
		{
		}

		public void PerformBooster()
		{
		}

		public void FinishBooster()
		{
		}

		public void ResourceNotEnough()
		{
		}

		public void PurchaseBooster(ResourceValueEventArgs args)
		{
		}
	}
}
