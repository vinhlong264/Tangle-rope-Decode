using Crescive.LiveEvents.SuperPowerup;
using Crescive.Navigation;
using Crescive.TransformUtils;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Crescive.LiveEvents.ConsecutiveWin
{
	[RequireComponent(typeof(Navigatable))]
	public class ConsecutiveWinClaimRewardsPanel : MonoBehaviour
	{
		[SerializeField]
		private PersistentConsecutiveWinSaveData PersistentConsecutiveWinData;

		[SerializeField]
		private GameObject superPowerupImageObject;

		[SerializeField]
		private RectTransform animSuperPowerupParent;

		[SerializeField]
		private Image animSuperPowerupImage;

		[SerializeField]
		private TransformChannel startPanelPlayButtonTransformChannel;

		[SerializeField]
		private CanvasGroup ignoreRaycastCanvasGroup;

		[SerializeField]
		private CanvasGroup dimmingBackgroundCanvasGroup;

		[SerializeField]
		private Button claimButton;

		[SerializeField]
		private GameObject animParticle;

		[SerializeField]
		[FormerlySerializedAs("superPowerUpEvents")]
		private SuperPowerUpSystem superPowerUpSystem;

		private Navigatable _navigatable;

		private Vector2? animSuperPowerupParentDefaultAnchorPos;

		private Vector3? animSuperPowerupImageDefaultScale;

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

		public void OnClaim()
		{
		}

		private void AnimateSuperPowerupImage()
		{
		}
	}
}
