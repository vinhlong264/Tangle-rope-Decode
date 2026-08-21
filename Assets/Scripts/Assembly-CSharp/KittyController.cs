using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class KittyController : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CAnimateSliderToAsync_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public KittyController _003C_003E4__this;

		public float ratio;

		public float speed;

		private UniTask.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[SerializeField]
	[Header("Kitty Assets")]
	private Image kittyImage;

	[SerializeField]
	private Sprite playerKittySprite;

	[SerializeField]
	private Sprite opponentKittySprite;

	[Header("Spine")]
	[SerializeField]
	private SkeletonGraphic spine;

	[SerializeField]
	private SkeletonDataAsset opponentAsset;

	[SerializeField]
	private SkeletonDataAsset playerAsset;

	[SpineAnimation(null, "skeletonDataAsset", true, false, false)]
	public string idleAnimation;

	[SpineAnimation(null, "skeletonDataAsset", true, false, false)]
	public string actionAnimation;

	[SerializeField]
	[Header("Player Indicator")]
	private GameObject playerIndicator;

	[SerializeField]
	private TMP_Text indicatorText;

	[SerializeField]
	[Header("Place Display")]
	private TMP_Text placeText;

	[SerializeField]
	private Image placeImage;

	[SerializeField]
	private Sprite[] placeSprites;

	[SerializeField]
	private Color[] placeColors;

	[SerializeField]
	[Header("Badge Display")]
	private GameObject badgeParent;

	[SerializeField]
	private Image glowImage;

	[Header("Slider & Ball")]
	[SerializeField]
	private Slider kittyProgressSlider;

	[SerializeField]
	private GameObject ball;

	private Sequence jumpSequence;

	public virtual void Initialize(bool isPlayerKitty, int place = 0, int point = 0, List<float> settingsCoinRewards = null)
	{
	}

	public void CloseBall()
	{
	}

	public void SetIndicatorText(string text, bool isActive)
	{
	}

	private void SetKittyAppearance(bool isPlayerKitty, int place)
	{
	}

	[AsyncStateMachine(typeof(_003CAnimateSliderToAsync_003Ed__23))]
	public UniTask AnimateSliderToAsync(float ratio, float speed = 0.5f)
	{
		return default(UniTask);
	}

	private void StartJumping()
	{
	}

	private void StopJumping()
	{
	}

	private void PlayActionThenIdle()
	{
	}
}
