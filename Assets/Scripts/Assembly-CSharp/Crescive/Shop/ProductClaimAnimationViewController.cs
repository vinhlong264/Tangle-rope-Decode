using Crescive.IAP;
using Crescive.LadderOffer;
using UnityEngine;

namespace Crescive.Shop
{
	public class ProductClaimAnimationViewController : MonoBehaviour
	{
		[SerializeField]
		private ShopBundleViewController bundleViewController;

		[SerializeField]
		private ShopBundleProductViewController bundleProductViewController;

		[SerializeField]
		private CanvasGroup canvasGroup;

		[SerializeField]
		private float appearDuration;

		[SerializeField]
		private float disappearDuration;

		[SerializeField]
		private float disappearScale;

		[SerializeField]
		private LadderOfferItemViewAnimator itemViewAnimator;

		public RectTransform RectTransform => null;

		public RectTransform RectTransformParent => null;

		public float AppearDuration => 0f;

		public float DisappearDuration => 0f;

		private void PlayAppearAnimation()
		{
		}

		private void PlayDisappearAnimation()
		{
		}

		private void SetupInternal(LadderOfferItemViewAnimator animator)
		{
		}

		public void Setup(Bundle bundle, LadderOfferItemViewAnimator animator)
		{
		}

		public void Setup(ProductInfo productInfo, LadderOfferItemViewAnimator animator)
		{
		}

		public void AnimateAppear()
		{
		}

		public void AnimateDisappear()
		{
		}
	}
}
