using Crescive.HelperTypes;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.LiveEvents.DynamicQuest
{
	public class DynamicQuestIntroPopupController : BaseDynamicQuestPopupController
	{
		[SerializeField]
		private StringSettableVariableReference description;

		[SerializeField]
		private BoolSettableVariableReference isTutorial;

		[SerializeField]
		private Image mainFeatureImage;

		[SerializeField]
		private bool dontSetFeatureImage;

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void OnHideCallback()
		{
		}

		protected override void SyncBindingsInternal()
		{
		}

		public void SetIsTutorial(bool value)
		{
		}
	}
}
