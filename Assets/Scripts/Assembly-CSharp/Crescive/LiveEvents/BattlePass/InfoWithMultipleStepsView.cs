using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.LiveEvents.BattlePass
{
	public class InfoWithMultipleStepsView : MonoBehaviour
	{
		[SerializeField]
		private Button bgContinueButton;

		[SerializeField]
		private bool overrideButtonToHidePanel;

		private Sequence stepsSequence;

		private List<InfoStepView> steps;

		private List<InfoStepView> Steps => null;

		private void OnEnable()
		{
		}

		private void Show()
		{
		}

		private void Hide()
		{
		}

		private void ResetView()
		{
		}

		private void DisableContinueButton()
		{
		}

		private void EnableContinueButton()
		{
		}

		private void AnimateSteps()
		{
		}

		private void HideSteps()
		{
		}
	}
}
