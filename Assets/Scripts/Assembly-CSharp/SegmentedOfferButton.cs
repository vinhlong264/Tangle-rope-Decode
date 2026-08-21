using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Crescive.Sequencer;
using CresciveCore;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using PersistentSO;
using SegmentedOffers;
using Spine.Unity;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SegmentedOfferButton : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CHandleOfferLifecycle_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public SegmentedOfferButton _003C_003E4__this;

		public long startTimestamp;

		public long endTimestamp;

		public CancellationToken token;

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
	private SegmentedOfferDataService dataService;

	[SerializeField]
	private string segmentedOfferId;

	[SerializeField]
	private LayoutElement layoutElement;

	[SerializeField]
	private GameObject buttonPivot;

	[SerializeField]
	private PersistentIntVariable buyCount;

	[SerializeField]
	private LevelSystem levelSystem;

	[SerializeField]
	private SequencerChannel sessionStartChannel;

	[SerializeField]
	private SequencerChannel levelEndChannel;

	[SerializeField]
	private UnityEvent openOfferPopUpAction;

	[SerializeField]
	private PersistentIntVariable tierPersistentIntVariable;

	[SerializeField]
	private PersistentBoolVariable tierPersistentBoolVariable;

	[SerializeField]
	private bool isThereSpineIcon;

	[SerializeField]
	private SkeletonGraphic skeletonGraphic;

	[SerializeField]
	private SkeletonDataAsset skeletonDataAsset;

	[SerializeField]
	private SkeletonGraphic skeletonGraphic2;

	[SerializeField]
	private SkeletonDataAsset skeletonDataAsset2;

	[SpineAnimation(null, "skeletonDataAsset", true, false, false)]
	public string idleAnimation;

	[SpineAnimation(null, "skeletonDataAsset", true, false, false)]
	public string actionAnimation;

	[SpineAnimation(null, "skeletonDataAsset2", true, false, false)]
	public string actionAnimation2;

	[SpineAnimation(null, "skeletonDataAsset2", true, false, false)]
	public string idleAnimation2;

	private CancellationTokenSource _cancellationTokenSource;

	private SegmentSettings _offer;

	private bool _isShown;

	private UserSegmentManager _userSegmentManager;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Setup()
	{
	}

	private void OnReturnHome()
	{
	}

	private void OnSessionStart()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnBuyCountChanged(int newValue)
	{
	}

	private void StartOfferLifecycleIfNeeded()
	{
	}

	[AsyncStateMachine(typeof(_003CHandleOfferLifecycle_003Ed__33))]
	private UniTaskVoid HandleOfferLifecycle(long startTimestamp, long endTimestamp, CancellationToken token)
	{
		return default(UniTaskVoid);
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	private void PlayActionThenIdle()
	{
	}
}
