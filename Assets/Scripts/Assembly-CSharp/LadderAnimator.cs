using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using ElephantSocial.Model;
using UnityEngine;
using UnityEngine.UI;

public class LadderAnimator : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public LadderAnimator _003C_003E4__this;

		public TaskCompletionSource<bool> jtcs;

		public TaskCompletionSource<bool> tcs;

		internal void _003CPlayRefreshSequenceAsync_003Eb__16()
		{
		}

		internal void _003CPlayRefreshSequenceAsync_003Eb__17()
		{
		}

		internal void _003CPlayRefreshSequenceAsync_003Eb__18(CachedBoard data)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CMoveInVerticalLayoutAsync_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public LadderAnimator _003C_003E4__this;

		public RectTransform content;

		public RectTransform item;

		public GameObject toDimGO;

		public float duration;

		public int fromRank;

		public int finalLocalPosition;

		public int toSiblingAbsIndex;

		public CancellationToken ct;

		public AutoCenterController autoCenter;

		public AnimationCurve curve;

		public float punch;

		private RectTransform _003Cc_003E5__2;

		private CanvasGroup _003Cdim_003E5__3;

		private LayoutElement _003Cle_003E5__4;

		private bool _003CprevIgnore_003E5__5;

		private float _003CmoveDur_003E5__6;

		private Canvas _003CitemCanvas_003E5__7;

		private bool _003CprevOverride_003E5__8;

		private int _003CprevOrder_003E5__9;

		private GameObject _003CmarkerGO_003E5__10;

		private RectTransform _003Cmarker_003E5__11;

		private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CPlayRefreshSequenceAsync_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public LadderAnimator _003C_003E4__this;

		private _003C_003Ec__DisplayClass19_0 _003C_003E8__1;

		public TournamentService service;

		private List<RectTransform> _003Call_003E5__2;

		private List<RectTransform> _003Cbadges_003E5__3;

		private List<RectTransform> _003Ccards_003E5__4;

		private float _003Coff_003E5__5;

		private TaskAwaiter<Task> _003C_003Eu__1;

		private TaskAwaiter<bool> _003C_003Eu__2;

		private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__3;

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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CPrepareAnimationSlotsAsync_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public int fromRank;

		public int toRank;

		public LadderAnimator _003C_003E4__this;

		public CancellationToken ct;

		public AutoCenterController autoCenter;

		private RectTransform _003Citem_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

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

	[Header("Anim")]
	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private float moveDuration;

	[SerializeField]
	private AnimationCurve ease;

	[SerializeField]
	private float punchScale;

	[Header("Enter/Exit")]
	[SerializeField]
	private float exitDur;

	[SerializeField]
	private float enterDur;

	[SerializeField]
	private float stagger;

	[SerializeField]
	private List<PlayerLadderCardController> playerLadderCards;

	private readonly HashSet<Transform> _movingItems;

	private CancellationTokenSource _cts;

	[Header("Refresh")]
	[SerializeField]
	private List<PlayerLadderBadgeController> playerLadderBadges;

	private bool _refreshing;

	private readonly Dictionary<RectTransform, float> _restX;

	public void PlayReorder(int fromRank, int toRank, CachedBoard board, AutoCenterController autoCenter)
	{
	}

	[AsyncStateMachine(typeof(_003CPrepareAnimationSlotsAsync_003Ed__11))]
	private Task PrepareAnimationSlotsAsync(int fromRank, int toRank, List<BoardPlayer> players, CancellationToken ct, AutoCenterController autoCenter)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CMoveInVerticalLayoutAsync_003Ed__12))]
	private Task MoveInVerticalLayoutAsync(RectTransform item, int toSiblingAbsIndex, float duration, AnimationCurve curve, float punch, RectTransform content, GameObject toDimGO, int finalLocalPosition, CancellationToken ct, int fromRank, AutoCenterController autoCenter)
	{
		return null;
	}

	private int GetAbsoluteSiblingIndexForLogicalCardIndex(int logicalIndex, RectTransform content)
	{
		return 0;
	}

	private static List<RectTransform> ActiveRects<T>(IEnumerable<T> src) where T : Component
	{
		return null;
	}

	public void PlayRefreshAnimation(TournamentService service)
	{
	}

	[AsyncStateMachine(typeof(_003CPlayRefreshSequenceAsync_003Ed__19))]
	private UniTaskVoid PlayRefreshSequenceAsync(TournamentService service)
	{
		return default(UniTaskVoid);
	}
}
