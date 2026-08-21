using Crescive.HelperTypes;
using Crescive.IAP;
using Crescive.Shop;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.LiveEvents.DynamicQuest
{
	public class DynamicQuestRewardRowItemView : MonoBehaviour
	{
		[SerializeField]
		private IAPDataService iapDataService;

		[SerializeField]
		private CommonProductViewController productViewController;

		[SerializeField]
		private CanvasGroup canvasGroup;

		[SerializeField]
		private Button button;

		[SerializeField]
		private Transform lockedIcon;

		[SerializeField]
		private Transform checkIcon;

		[SerializeField]
		private Transform highlightDiamond;

		[SerializeField]
		private StringSettableVariableReference rewardInfoVar;

		[SerializeField]
		private BoolSettableVariableReference showActivateGoldenPassTextVar;

		[SerializeField]
		private bool isGoldenPassItem;

		private IPackInfo _packInfo;

		public Button Button => null;

		public CanvasGroup CanvasGroup => null;

		public void Setup(string itemProductId, bool goldenPassItem)
		{
		}

		public void SyncBindings(bool canPurchaseGoldenPass)
		{
		}

		public void SetIsLocked(bool isLocked)
		{
		}
	}
}
