using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Crescive.IAP;
using Crescive.Navigation;
using Crescive.Shop;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.LiveEvents.BattlePass
{
	[RequireComponent(typeof(Navigatable))]
	public class BattlePassFinishPopUp : MonoBehaviour
	{
		public enum State
		{
			BattlePassEnded = 0,
			OpenBonusChest = 1,
			ClaimBonusChest = 2,
			ClaimUnclaimedRewards = 3
		}

		[CompilerGenerated]
		private sealed class _003CBonusChestOpenCrt_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BattlePassFinishPopUp _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CBonusChestOpenCrt_003Ed__27(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CClaimBonusChestCrt_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BattlePassFinishPopUp _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CClaimBonusChestCrt_003Ed__29(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CGoNextCrt_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BattlePassFinishPopUp _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CGoNextCrt_003Ed__28(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CRewardsClaimCrt_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BattlePassFinishPopUp _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CRewardsClaimCrt_003Ed__26(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private Navigatable? _navigatable;

		[Header("Dependencies")]
		[SerializeField]
		private BattlePassSystem battlePassSystem;

		[Header("UI References: Battle Pass Ended")]
		[SerializeField]
		private GameObject battlePassEndedPopUpPanel;

		[Header("UI References: Claim Rewards")]
		[SerializeField]
		private GameObject claimUnclaimedRewardsPanel;

		[SerializeField]
		private GameObject rewardsParent;

		[SerializeField]
		private ItemView rewardItemPrefab;

		[SerializeField]
		private GameObject rewardsTapToClaimTextParent;

		[SerializeField]
		private Button claimRewardsButton;

		[SerializeField]
		[Header("UI References: Claim BonusChest")]
		private GameObject claimBonusChestPanel;

		[SerializeField]
		private TextMeshProUGUI coinFromBonusChestText;

		[SerializeField]
		private GameObject bonusChestTapToOpenTextParent;

		[SerializeField]
		private GameObject bonusChestTapToClaimTextParent;

		[SerializeField]
		private Transform claimBonusChestPanelScaleDownAnimationParent;

		[SerializeField]
		private GameObject goldRewardAnimationParent;

		[Header("External Dependencies")]
		[SerializeField]
		private IAPDataService iapDataService;

		[SerializeField]
		private ShopProductsAssetData shopProductsAssetData;

		private State _state;

		private Coroutine? _coroutine;

		private bool _coroutinePlaying;

		private Navigatable Navigatable => null;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Setup()
		{
		}

		private void SetupState(State state)
		{
		}

		private void SetUpRewards(IEnumerable<string> productInfos)
		{
		}

		[IteratorStateMachine(typeof(_003CRewardsClaimCrt_003Ed__26))]
		private IEnumerator RewardsClaimCrt()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CBonusChestOpenCrt_003Ed__27))]
		private IEnumerator BonusChestOpenCrt()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGoNextCrt_003Ed__28))]
		private IEnumerator GoNextCrt()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CClaimBonusChestCrt_003Ed__29))]
		private IEnumerator ClaimBonusChestCrt()
		{
			return null;
		}

		public void GoNext()
		{
		}
	}
}
