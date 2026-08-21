using System.Collections.Generic;
using Crescive.IAP;
using Crescive.Shop;
using DG.Tweening;
using UnityEngine;

namespace Crescive.LadderOffer
{
	public class LadderOfferItemViewAnimator : MonoBehaviour
	{
		[SerializeField]
		private IAPDataService iapDataService;

		[SerializeField]
		private LadderOfferItemView ladderOfferItemView;

		[Header("UI")]
		[SerializeField]
		private CanvasGroup canvasGroup;

		[SerializeField]
		private RectTransform claimButton;

		[SerializeField]
		private RectTransform checkIcon;

		[SerializeField]
		private ProductClaimAnimationViewController productClaimAnimationViewPrefab;

		[SerializeField]
		private float productClaimAnimateInterval;

		[SerializeField]
		private float productClaimAnimateEndDelay;

		[SerializeField]
		private float productClaimAnimateDisappearDelay;

		[SerializeField]
		private float productClaimViewSizeScale;

		private List<Tween> tweens;

		public CanvasGroup CanvasGroup => null;

		public bool IsAnimatingClaim => false;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private List<ProductClaimAnimationViewController> GetClaimAnimationViews(LadderOfferItemView itemView)
		{
			return null;
		}

		private void PlayClaimAnimations(LadderOfferItemView itemView)
		{
		}

		private void PlayItemClaimedAnimation()
		{
		}

		private void PlayProductClaimAnimations(LadderOfferItemView itemView)
		{
		}
	}
}
