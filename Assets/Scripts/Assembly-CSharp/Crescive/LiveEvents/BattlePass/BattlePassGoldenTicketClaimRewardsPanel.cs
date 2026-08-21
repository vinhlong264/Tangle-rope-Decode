using Crescive.Navigation;
using Crescive.TransformUtils;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.LiveEvents.BattlePass
{
	[RequireComponent(typeof(Navigatable))]
	public class BattlePassGoldenTicketClaimRewardsPanel : MonoBehaviour
	{
		[SerializeField]
		private BattlePassSystem battlePassSystem;

		[SerializeField]
		private GameObject heartImageObject;

		[SerializeField]
		private RectTransform animHeartParent;

		[SerializeField]
		private RectTransform animHeartRectTransform;

		[SerializeField]
		private TransformChannel targetHeartTransformChannel;

		[SerializeField]
		private CanvasGroup ignoreRaycastCanvasGroup;

		[SerializeField]
		private CanvasGroup dimmingBackgroundCanvasGroup;

		[SerializeField]
		private Button claimButton;

		private Navigatable? _navigatable;

		private Vector2? animHeartParentDefaultAnchorPos;

		private Vector3? animHeartImageDefaultScale;

		private Sequence animSequence;

		private Navigatable Navigatable => null;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void ResetViews()
		{
		}

		public void OnTapToClaim()
		{
		}

		private void AnimateHeartImage()
		{
		}
	}
}
