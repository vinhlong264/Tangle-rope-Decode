using Crescive.HelperTypes;
using Crescive.IAP;
using Crescive.Shop;
using UnityEngine;

namespace Crescive.LiveEvents.DynamicQuest
{
	[DefaultExecutionOrder(1)]
	public class DynamicQuestProgressBarRewardViewController : MonoBehaviour
	{
		[SerializeField]
		private IAPDataService iapDataService;

		[SerializeField]
		private CommonProductViewController regularProductView;

		[SerializeField]
		private CommonProductViewController goldenPassProductView;

		[SerializeField]
		private RectTransform visualsPivot;

		[SerializeField]
		private Canvas overrideSortCanvas;

		[SerializeField]
		private RectTransform soloParent;

		[SerializeField]
		private RectTransform duoTopParent;

		[SerializeField]
		private RectTransform duoBottomParent;

		[SerializeField]
		private BoolSettableVariableReference isGoldenPassActiveVar;

		[SerializeField]
		private BoolSettableVariableReference isDuoVar;

		[SerializeField]
		private BoolSettableVariableReference isDescriptionAvailableVar;

		[SerializeField]
		private StringSettableVariableReference regularRewardInfoVar;

		[SerializeField]
		private StringSettableVariableReference goldenPassRewardInfoVar;

		[SerializeField]
		private bool didSetup;

		[SerializeField]
		private bool isGoldenPassActive;

		[SerializeField]
		private bool areStepsFinished;

		[SerializeField]
		private bool areRewardTypesDifferent;

		private IProductInfo _regularRewardProductInfo;

		private IProductInfo _goldenPassRewardProductInfo;

		private IPackInfo _regularRewardPack;

		private IPackInfo _goldenPassRewardPack;

		private void OnEnable()
		{
		}

		private void SyncBindings()
		{
		}

		private void SetupViews()
		{
		}

		public void Setup(string regularRewardId, string goldenPassRewardId, bool goldenPassActive, bool stepsFinished)
		{
		}

		public void SetOnTop(bool value)
		{
		}

		public void SetVisualsActive(bool value)
		{
		}
	}
}
