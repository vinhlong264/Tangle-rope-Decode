using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Crescive.LadderOffer;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DirectStoreSelectionPanelController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCheckEnable_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DirectStoreSelectionPanelController _003C_003E4__this;

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
		public _003CCheckEnable_003Ed__20(int _003C_003E1__state)
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

	public const string DefaultAmountText = "+{PERCENT}%\nMORE!";

	[SerializeField]
	private CanvasGroup canvasGroup;

	[SerializeField]
	private RectMask2D rectMask2D;

	[SerializeField]
	private Button onOffButton;

	[SerializeField]
	private Sprite onImage;

	[SerializeField]
	private Sprite offImage;

	[SerializeField]
	private Image moreTextImage;

	[SerializeField]
	private Sprite moreTextActive;

	[SerializeField]
	private Sprite moreTextPassive;

	[SerializeField]
	private GameObject inShopSpaceHolder;

	[SerializeField]
	private GameObject line;

	[SerializeField]
	private TMP_Text rewardAmountText;

	[SerializeField]
	private DirectStoreModifyTarget[] modifyTargets;

	[SerializeField]
	private DirectStoreConditionChecker[] statusCheckers;

	[SerializeField]
	private LadderOfferView ladderOfferViewListener;

	public bool isDisabledInThisPopUp { get; private set; }

	private void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CCheckEnable_003Ed__20))]
	private IEnumerator CheckEnable()
	{
		return null;
	}

	private void LadderOfferViewListenerOnShowEvent()
	{
	}

	private void OnDisable()
	{
	}

	private bool IsAllConditionsMatched()
	{
		return false;
	}

	private void OnClick()
	{
	}

	private void UpdateUI(bool useFlow)
	{
	}
}
