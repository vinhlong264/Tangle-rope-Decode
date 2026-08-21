using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Crescive.CreatorMode;
using Crescive.Draggables;
using Crescive.TwistedTangle;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Pool;

namespace Systems.ColorGameMode
{
	public class GoalUI : MonoBehaviour
	{
		[Serializable]
		public struct TargetSnapshot
		{
			public int ColorIndex;

			public int Remaining;

			public int Initial;

			public bool Active;
		}

		[CompilerGenerated]
		private sealed class _003CDelayedRopeFix_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GoalUI _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CDelayedRopeFix_003Ed__42(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public static GoalUI Instance;

		[SerializeField]
		private GoalTargetObjectUI[] goalTargetObjects;

		[SerializeField]
		private RopesChannel ropesChannel;

		[SerializeField]
		private LevelSaverChannel levelSaverChannel;

		[SerializeField]
		private LevelCreatorChannel levelCreatorChannel;

		[SerializeField]
		private RectTransform[] goalTargetObjectRects;

		[SerializeField]
		private RectTransform layoutGroup1;

		[SerializeField]
		private RectTransform layoutGroup2;

		[SerializeField]
		private GoalParticleController flyingTokenPrefab;

		[SerializeField]
		private RectTransform targetCanvas;

		[SerializeField]
		private float levelWinDelay;

		[SerializeField]
		private CanvasGroup canvasGroup;

		[SerializeField]
		private DraggablesControllerChannel dgcs;

		[SerializeField]
		[Header("Token Pool")]
		private int tokenPoolInitial;

		[SerializeField]
		private int tokenPoolMax;

		public UnityEvent OnRopesNotEnough;

		public bool IsCutBoosterUsed;

		public bool isLastFailedWithIce;

		private LevelCreatorSaveData.StateData before;

		private Tween delayedFail;

		private Dictionary<int, int> _beforeTargetDataDictionary;

		private float _winDelayStart;

		private bool _finalAnimInputLocked;

		private bool _eventsBlocked;

		private bool _blockRopeSelect;

		private int _activeMerges;

		private int _inFlightTokens;

		private bool _hasMoveSnapshot;

		private ObjectPool<GoalParticleController> _tokenPool;

		[SerializeField]
		private float speedDebug;

		public bool IsColoredMode { get; set; }

		public bool IsCurrentlyInUndo { get; set; }

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void ResetRuntime()
		{
		}

		private void OnUndoMove(ColorModeEvents.OnUndoMove p)
		{
		}

		[IteratorStateMachine(typeof(_003CDelayedRopeFix_003Ed__42))]
		private IEnumerator DelayedRopeFix()
		{
			return null;
		}

		private void TakeSnapshotNow()
		{
		}

		private void SaveState()
		{
		}

		public bool IsTargetsDone()
		{
			return false;
		}

		public bool IsTargetsDoneForWin()
		{
			return false;
		}

		private bool AreTargetsDoneNow()
		{
			return false;
		}

		private void OnRopesMergeStarted(GameEvents.OnRopesMergeStarted p)
		{
		}

		private void OnRopesMerged(GameEvents.OnRopesMerged p)
		{
		}

		private int ResolveTargetIndexOnMerged(GameEvents.OnRopesMerged p)
		{
			return 0;
		}

		private void ApplyHitOrSkip(int index, Vector3 worldPosition)
		{
		}

		private void PlayToken(Vector3 worldStartPos, int targetIndex)
		{
		}

		private void SafeFailCheck()
		{
		}

		private bool CheckIsGoalTargetReachable()
		{
			return false;
		}

		private bool CheckIsGoalTargetReachable(bool bypassAnimationGuard)
		{
			return false;
		}

		private void OnSetColorModeTargets(ColorModeEvents.OnSetColorModeTargets p)
		{
		}

		public float GetTargetCompletePercentage()
		{
			return 0f;
		}

		public void OverrideSortingGoals(int sort, bool isAdd)
		{
		}

		private bool IsRopeOnTarget(int targetIndex, Vector3 worldStartPos)
		{
			return false;
		}

		private void OnTargetAnimationSkipped(int targetIndex, Vector3 worldStartPos, string reason)
		{
		}

		private void SetInput(bool open)
		{
		}

		private void BlockInteractionsForFail()
		{
		}

		private bool WillFailWithCurrentState()
		{
			return false;
		}

		private bool IsStableState()
		{
			return false;
		}

		private void CheckEndMove()
		{
		}

		public void ResumeAfterFailOrContinue()
		{
		}

		public GoalTargetObjectUI[] GetGoalTargetObjectUIs()
		{
			return null;
		}

		public List<TargetSnapshot> GetVisualSnapshot()
		{
			return null;
		}
	}
}
