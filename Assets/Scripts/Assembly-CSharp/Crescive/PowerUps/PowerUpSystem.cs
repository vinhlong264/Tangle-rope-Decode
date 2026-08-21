using System.Collections.Generic;
using Crescive.HelperTypes;
using Crescive.ResourceSystem;
using CresciveCore;
using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.PowerUps
{
	[CreateAssetMenu(fileName = "Power Up System", menuName = "Crescive/Power Ups/Core/Power Up System")]
	public class PowerUpSystem : ScriptableObject
	{
		[SerializeField]
		private LevelSystem levelSystem;

		[SerializeField]
		private List<PowerUpGroup> powerUpGroups;

		[SerializeField]
		private List<PowerUpSource> powerUpSources;

		[SerializeField]
		private PersistentBoolVariable didClaimFirstTimeThisLevel;

		[SerializeField]
		private BoolVariable powerUpsEnabled;

		[SerializeField]
		private List<BoolVariableReference> anyPowerUpClaimPopupConditions;

		[SerializeField]
		private List<PowerUpChannel> currentPowerUps;

		public UnityEvent<PowerUpChannel> OnSelected;

		public UnityEvent<PowerUpChannel> OnUnselected;

		public UnityEvent<PowerUpChannel> OnStarted;

		public UnityEvent<PowerUpChannel> OnCanceled;

		public UnityEvent<PowerUpChannel> OnPerformed;

		public UnityEvent<PowerUpChannel> OnFinished;

		public UnityEvent<PowerUpChannel> OnCanceledOrFinished;

		public UnityEvent<PowerUpChannel> OnResourceNotEnough;

		public UnityEvent<PowerUpChannel> OnResourceIsInfinite;

		public UnityEvent<PowerUpChannel> OnTutorialActivated;

		public UnityEvent<PowerUpChannel> OnMustUseOnce;

		public UnityEvent<PowerUpChannel, ResourceValueEventArgs> OnPowerUpPurchasedWithResource;

		public UnityEvent OnCurrentPowerUpsCleared;

		public bool Enabled => false;

		public List<PowerUpChannel> PowerUps => null;

		public List<PowerUpSource> PowerUpSources => null;

		public List<PowerUpChannel> AvailablePowerUps => null;

		public List<string> AvailablePowerUpIds => null;

		public List<PowerUpChannel> CurrentPowerUps => null;

		public PersistentBoolVariable DidClaimFirstTimeThisLevel => null;

		private bool IsPowerUpAvailable(PowerUpChannel powerUpChannel)
		{
			return false;
		}

		public void AddCurrentPowerUp(PowerUpChannel powerUpChannel)
		{
		}

		public void RemoveCurrentPowerUp(PowerUpChannel powerUpChannel)
		{
		}

		public void ClearCurrentPowerUps()
		{
		}

		public bool IsPowerUpSelected(PowerUpChannel powerUpChannel)
		{
			return false;
		}

		public bool IsPowerUpInUseExcept(PowerUpChannel powerUpChannel)
		{
			return false;
		}

		public PowerUpChannel GetPowerUpWithId(string powerUpId)
		{
			return null;
		}

		public PowerUpChannel GetAvailablePowerUpWithId(string powerUpId)
		{
			return null;
		}

		private bool DidReachPowerUpMinLevel(PowerUpChannel powerUp)
		{
			return false;
		}

		public bool IsPowerUpUnlocked(PowerUpChannel powerUp)
		{
			return false;
		}

		public bool DidReachFirstPowerUpMinLevel()
		{
			return false;
		}

		public bool CanShowClaimPopupForAnyPowerUp()
		{
			return false;
		}

		public bool CanClaimAnyPowerUpNow()
		{
			return false;
		}

		public bool CanClaimPowerUpNow(PowerUpChannel powerUpChannel)
		{
			return false;
		}

		public bool CanClaimPowerUpFirstTimeFinalCheck(PowerUpChannel powerUpChannel)
		{
			return false;
		}

		public bool CanUseAnyPowerUpFirstTimeNowCondition()
		{
			return false;
		}

		private bool CanUsePowerUpFirstTimeNow(PowerUpChannel powerUp)
		{
			return false;
		}

		public bool AllPowerUpsHaveState(PowerUpState powerUpState, List<PowerUpChannel> excludedPowerUps)
		{
			return false;
		}

		public bool AnyPowerUpHaveState(PowerUpState powerUpState, List<PowerUpChannel> excludedPowerUps)
		{
			return false;
		}

		public bool AllPowerUpsNotHaveState(PowerUpState powerUpState)
		{
			return false;
		}

		public List<PowerUpChannel> GetAllAvailablePowerUpsBeforeThis(PowerUpChannel powerUpChannel)
		{
			return null;
		}

		public List<PowerUpChannel> GetAllAvailablePowerUpsAfterThis(PowerUpChannel powerUpChannel)
		{
			return null;
		}

		public bool AreAllAvailablePowerUpsBeforeThisUnlocked(PowerUpChannel powerUpChannel)
		{
			return false;
		}

		public bool AreAllAvailablePowerUpsBeforeThisUsedOnce(PowerUpChannel powerUpChannel)
		{
			return false;
		}

		public bool AreAllAvailablePowerUpsAfterThisUnlockedAndUsedOnce(PowerUpChannel powerUpChannel, out List<PowerUpChannel> unusedPowerUps)
		{
			unusedPowerUps = null;
			return false;
		}

		public int GetMinLevelForPowerUp(PowerUpChannel powerUpChannel)
		{
			return 0;
		}
	}
}
