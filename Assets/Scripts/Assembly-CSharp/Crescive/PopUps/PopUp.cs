using System;
using System.Collections.Generic;
using Crescive.HelperTypes;
using UnityAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.PopUps
{
	public abstract class PopUp : MonoBehaviour
	{
		[SerializeField]
		private GameObject popupPanel;

		[SerializeField]
		private bool handleEnableDisable;

		[Obsolete("Use canShowConditions")]
		[SerializeField]
		protected List<AtomCondition> showConditions;

		[SerializeField]
		protected List<BoolVariableReference> canShowConditions;

		public UnityEvent<PopUp> OnShow;

		public UnityEvent<PopUp> OnHide;

		[field: SerializeField]
		public int Priority { get; private set; }

		protected void ShowWithActions(Action beforeShowAction = null, Action afterShowAction = null)
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		public void SetPriority(int priority)
		{
		}

		protected virtual void BeforeShowInternal()
		{
		}

		protected virtual void AfterShowInternal()
		{
		}

		protected virtual void BeforeHideInternal()
		{
		}

		protected virtual void AfterHideInternal()
		{
		}

		protected abstract bool CanShowInternal();

		public bool CanShow()
		{
			return false;
		}
	}
}
