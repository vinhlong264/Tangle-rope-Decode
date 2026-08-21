using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Crescive.IAP;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Crescive.LadderOffer
{
	public class LadderOfferView : MonoBehaviour
	{
		[Header("References")]
		[SerializeField]
		private LadderOfferSystem ladderOfferSystem;

		[SerializeField]
		private IAPStoreControllerChannel iapStoreControllerChannel;

		[SerializeField]
		[Header("Settings")]
		private string id;

		[Header("UI")]
		[SerializeField]
		private Transform hiddenItemsParent;

		[SerializeField]
		private List<Transform> itemSlots;

		[Header("Bindings")]
		[SerializeField]
		private StringVariableInstancer titleName;

		[SerializeField]
		private Image featureImage;

		[SerializeField]
		private bool didSetData;

		[SerializeField]
		private bool didSetupOnce;

		[SerializeField]
		private LadderOfferData data;

		[SerializeField]
		private LadderOfferSettings settings;

		[SerializeField]
		private bool canClaim;

		[SerializeField]
		private bool forceShown;

		[SerializeField]
		private List<LadderOfferItemView> itemViews;

		public UnityEvent<bool> OnCanClaimChanged;

		public UnityEvent<LadderOfferItemView> OnItemClaimed;

		public UnityEvent OnItemClaimFinished;

		private LadderOfferSaveData SaveData => null;

		public List<LadderOfferItemView> ItemViews => null;

		public List<Transform> ItemSlots => null;

		public int DisplayCount => 0;

		public int LastItemIndex => 0;

		public LadderOfferData Data => null;

		public bool PreviousActiveItemsAreLastItems => false;

		public bool CanClaim => false;

		public event Action onShowEvent
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

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SyncBindings()
		{
		}

		private void Setup()
		{
		}

		private void SetupData()
		{
		}

		private void SetupItems()
		{
		}

		private void CreateItem(LadderOfferItemData itemData, int itemDataIndex, int startIndex, LadderOfferSaveData saveData)
		{
		}

		private void ClaimItem(LadderOfferItemView itemView)
		{
		}

		private void OnItemClaimedCallback(LadderOfferItemClaimedEventArgs args)
		{
		}

		private LadderOfferItemView GetItemViewByData(LadderOfferItemData itemData)
		{
			return null;
		}

		public bool IsItemUnlocked(LadderOfferItemView itemView)
		{
			return false;
		}

		public bool IsItemClaimed(LadderOfferItemView itemView)
		{
			return false;
		}

		public void SetCanClaim(bool value)
		{
		}

		public void RemoveItem(LadderOfferItemView itemView)
		{
		}

		public void TriggerItemClaimFinished()
		{
		}

		public void OnShow()
		{
		}

		public void OnHide()
		{
		}

		public void OnOfferShow()
		{
		}
	}
}
