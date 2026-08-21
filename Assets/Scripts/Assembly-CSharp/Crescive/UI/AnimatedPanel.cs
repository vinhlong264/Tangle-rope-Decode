using System.Collections.Generic;
using Crescive.Utils;
using UnityEngine;

namespace Crescive.UI
{
	[DefaultExecutionOrder(-1)]
	public class AnimatedPanel : MonoBehaviour
	{
		[SerializeField]
		private bool autoInitialize;

		[SerializeField]
		private bool autoAnimateOnEnable;

		[SerializeField]
		private List<CanvasGroup> fadeTargets;

		[SerializeField]
		private List<RectTransform> scaleTargets;

		[SerializeField]
		private List<RectTransform> bounceTargets;

		[SerializeField]
		private List<RectTransform> bottomSlideTargets;

		[SerializeField]
		private List<RectTransform> topSlideTargets;

		[SerializeField]
		private List<RectTransform> leftSlideTargets;

		[SerializeField]
		private List<RectTransform> rightSlideTargets;

		[SerializeField]
		private List<RectTransform> widthExpandTargets;

		[SerializeField]
		private List<RectTransform> relativeMoveTargets;

		public float initialDelay;

		public Settings<FloatAnimationSettings> fadeSettings2;

		public Settings<Vector3AnimationSettings> scaleSettings2;

		public Settings<Vector3AnimationSettings> bounceSettings2;

		public Settings<VoidAnimationSettings> bottomSlideSettings2;

		public Settings<VoidAnimationSettings> topSlideSettings2;

		public Settings<VoidAnimationSettings> leftSlideSettings2;

		public Settings<VoidAnimationSettings> rightSlideSettings2;

		public Settings<FloatAnimationSettings> widthExpandSettings2;

		public Settings<Vector3AnimationSettings> relativeMoveSettings2;

		private List<AnimatedPanelTargetData<float>> fadeTargetsData;

		private List<AnimatedPanelTargetData<Vector3>> scaleTargetsData;

		private List<AnimatedPanelTargetData<Vector3>> bounceTargetsData;

		private List<AnimatedPanelTargetData<float>> bottomSlideTargetsData;

		private List<AnimatedPanelTargetData<float>> topSlideTargetsData;

		private List<AnimatedPanelTargetData<float>> leftSlideTargetsData;

		private List<AnimatedPanelTargetData<float>> rightSlideTargetsData;

		private List<AnimatedPanelTargetData<float>> widthExpandTargetsData;

		private List<AnimatedPanelTargetData<Vector3>> relativeMoveTargetsData;

		private FloatAnimationSettings fadeSettings => null;

		private Vector3AnimationSettings scaleSettings => null;

		private Vector3AnimationSettings bounceSettings => null;

		private VoidAnimationSettings bottomSlideSettings => null;

		private VoidAnimationSettings topSlideSettings => null;

		private VoidAnimationSettings leftSlideSettings => null;

		private VoidAnimationSettings rightSlideSettings => null;

		private FloatAnimationSettings widthExpandSettings => null;

		private Vector3AnimationSettings relativeMoveSettings => null;

		private bool AutoInitializeOnAwake => false;

		private bool ShowFadeSettings => false;

		private bool ShowScaleSettings => false;

		private bool ShowBounceSettings => false;

		private bool ShowBottomSlideSettings => false;

		private bool ShowTopSlideSettings => false;

		private bool ShowLeftSlideSettings => false;

		private bool ShowRightSlideSettings => false;

		private bool ShowWidthExpandSettings => false;

		private bool ShowRelativeMoveSettings => false;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void InitializeTargets()
		{
		}

		private void KillTargets()
		{
		}

		private void AnimateTargets()
		{
		}

		public void TryUpdateTotalDuration(float duration, float delay, ref float totalDuration)
		{
		}

		public void InitializeTargetsNow()
		{
		}

		public void KillAndAnimateTargets()
		{
		}

		public float GetTotalDuration()
		{
			return 0f;
		}
	}
}
