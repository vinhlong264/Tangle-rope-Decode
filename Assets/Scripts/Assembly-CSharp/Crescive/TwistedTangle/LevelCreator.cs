using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Systems.Randomization.Scripts;
using BrunoMikoski.AnimationSequencer;
using Crescive.AutoLayout;
using Crescive.CreatorMode;
using Crescive.Draggables;
using Crescive.HelperTypes;
using Crescive.Levels;
using Crescive.Prefabs;
using Crescive.Sequencer;
using Crescive.TransformUtils;
using Crescive.TwistedTangle.Channel;
using CresciveCore;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using Obi;
using PersistentSO;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Serialization;

namespace Crescive.TwistedTangle
{
	public class LevelCreator : BaseLevelCreator<LevelCreatorData, LevelCreatorSaveData>
	{
		[CompilerGenerated]
		private sealed class _003CCreateLevelCoroutine_003Ed__86 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LevelCreator _003C_003E4__this;

			public LevelCreatorSaveData saveData;

			public int index;

			private LevelManager _003ClevelManager_003E5__2;

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
			public _003CCreateLevelCoroutine_003Ed__86(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CCreateLevelInternal_003Ed__101 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LevelCreator _003C_003E4__this;

			public LevelCreatorSaveData saveData;

			public int index;

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
			public _003CCreateLevelInternal_003Ed__101(int _003C_003E1__state)
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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCreateStage_003Ed__88 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public LevelCreator _003C_003E4__this;

			public LevelCreatorSaveData.StageData stageData;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLoadNextStage_003Ed__56 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public LevelCreatorSaveData.StageData stageData;

			public LevelCreator _003C_003E4__this;

			private GameObject _003Ccameras_003E5__2;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CMoveCameraBackToMap_003Ed__96 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public Transform cameras;

			public LevelCreator _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CMoveCameraBackToMapFromRight_003Ed__97 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public Transform cameras;

			public LevelCreator _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CMoveCameraOutOfMap_003Ed__95 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public Transform cameras;

			public LevelCreator _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CMoveCameraOutOfMapToLeft_003Ed__98 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public Transform cameras;

			public LevelCreator _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CPlayStagePreview_003Ed__87 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public LevelCreatorSaveData saveData;

			public LevelCreator _003C_003E4__this;

			private Transform _003Ccameras_003E5__2;

			private UniTask.Awaiter _003C_003Eu__1;

			private int _003Ci_003E5__3;

			private LevelCreatorSaveData.StageData _003CstageData_003E5__4;

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
		private struct _003CPreviewCameraMovement_003Ed__55 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public LevelCreator _003C_003E4__this;

			private GameObject _003Ccameras_003E5__2;

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
		private PrefabSource pinPrefabSource;

		[SerializeField]
		public PrefabSource ropePrefabSource;

		[SerializeField]
		public ColumnEntity columnPrefab;

		[SerializeField]
		public ClampEntity clampPrefab;

		[SerializeField]
		public KeyEntity keyPrefab;

		[SerializeField]
		private IntVariable moveCount;

		[SerializeField]
		private BoolVariable hasMoveCount;

		[SerializeField]
		private BoolVariable useNearColors;

		[SerializeField]
		private BoolVariable useCustomNearColors;

		[SerializeField]
		private ColorValueList customNearColors;

		[SerializeField]
		private BoolVariable hasTimeLimit;

		[SerializeField]
		private IntVariable timeLimit;

		[SerializeField]
		private MapProfileData mapProfileData;

		[SerializeField]
		private LevelDifficultySetterAction difficultySetterAction;

		[SerializeField]
		private PinsChannel pinsChannel;

		[SerializeField]
		private RopesChannel ropesChannel;

		[SerializeField]
		private DraggablesChannel columnsChannel;

		[SerializeField]
		private ClampsChannel clampsChannel;

		[SerializeField]
		private KeysChannel keysChannel;

		[SerializeField]
		private DropTargetsChannel dropTargetsChannel;

		[SerializeField]
		private DropTargetHoldersChannel dropTargetHoldersChannel;

		[SerializeField]
		private TransformAutoGridLayoutChannel transformAutoGridLayoutChannel;

		[SerializeField]
		private PinSlotsChannel pinSlotsChannel;

		[SerializeField]
		private TransformChannel mapTransformChannel;

		[SerializeField]
		private LoadedLevelDataChannel loadedLevelDataChannel;

		[SerializeField]
		private LevelSystem levelSystem;

		[SerializeField]
		private RandomizationDataService randomizationDataService;

		[SerializeField]
		private RopesOptimizerChannel optimizerChannel;

		[SerializeField]
		private VoidEvent stageCreated;

		[SerializeField]
		private float camMoveDistance;

		[SerializeField]
		private float camMoveDurationOut;

		[SerializeField]
		private float camMoveDurationIn;

		[SerializeField]
		private CustomEase camOutOfMapEase;

		[SerializeField]
		private CustomEase camBackToMapEase;

		[SerializeField]
		private float delayAfterMapCreation;

		[SerializeField]
		private float camMoveDistanceLeft;

		[SerializeField]
		private float camMoveDurationOutLeft;

		[SerializeField]
		private float camMoveDurationInLeft;

		[SerializeField]
		private Ease camOutOfMapEaseLeft;

		[SerializeField]
		private Ease camBackToMapEaseLeft;

		[SerializeField]
		private float camPreviewLookDelay;

		[SerializeField]
		private float camPostTransitionBuffer;

		[SerializeField]
		private VoidEvent resetPinsRotation;

		[SerializeField]
		private PersistentIntVariable failCount;

		[SerializeField]
		private TransformAutoGridLayoutChannel gridLayoutChannel;

		[SerializeField]
		private StringVariable levelType;

		private List<int> lastColors;

		public static bool IsLastLoadedColoredLevel;

		[FormerlySerializedAs("isStagedLevel")]
		[SerializeField]
		private BoolVariableReference isEditorScene;

		[SerializeField]
		private BoolVariable isInputDisabled;

		[SerializeField]
		private SequenceStep splash;

		[SerializeField]
		private StringReference currentLevelDifficulty;

		[SerializeField]
		private StringReference hardLevelDifficulty;

		[SerializeField]
		private StringReference veryHardLevelDifficulty;

		private void ForceCamerasToPosition()
		{
		}

		[AsyncStateMachine(typeof(_003CPreviewCameraMovement_003Ed__55))]
		private UniTask PreviewCameraMovement()
		{
			return default(UniTask);
		}

		[AsyncStateMachine(typeof(_003CLoadNextStage_003Ed__56))]
		public UniTask LoadNextStage(LevelCreatorSaveData.StageData stageData)
		{
			return default(UniTask);
		}

		private void CreatePin(PinData pinData)
		{
		}

		private void CreateRope(RopeData ropeData)
		{
		}

		private void CreateColumn(ColumnData columnData)
		{
		}

		private void CreateClamp(ClampData clampData)
		{
		}

		private void CreateKey(KeyData keyData)
		{
		}

		private void SetupRopeParticles(ObiRope rope, RopeData ropeData)
		{
		}

		public void SetStateData(LevelCreatorSaveData.StateData state)
		{
		}

		private void CreatePins(List<PinData> pinsData)
		{
		}

		private void CreateRopes(List<RopeData> ropesData)
		{
		}

		private void CreateColumns(List<ColumnData> columnsData)
		{
		}

		private void CreateClamps(List<ClampData> clampsData)
		{
		}

		private void CreateKeys(List<KeyData> keysData)
		{
		}

		private void SetRopeWidths(List<RopeWidthData> ropeWidthsData)
		{
		}

		private void SetupLockSlots(List<LockSlotData> lockSlotsData)
		{
		}

		private void SetupGoldenRopes(List<GoldenRopeData> goldenRopesData)
		{
		}

		private void SetupMapProfile(LevelCreatorSaveData.StageData stageData)
		{
		}

		private void SetupMoveCount(LevelCreatorSaveData saveData)
		{
		}

		private void SetupTimeLimit(LevelCreatorSaveData saveData)
		{
		}

		private void SetupColorSettings(LevelCreatorSaveData.StageData stageData)
		{
		}

		private void SetupDifficulty(string difficulty)
		{
		}

		private void SetupLoadedLevelData(LevelCreatorSaveData saveData)
		{
		}

		private void ClearPins()
		{
		}

		private void ClearRopes()
		{
		}

		private void ClearColumns()
		{
		}

		private void ClearClamps()
		{
		}

		private void ClearKeys()
		{
		}

		private void ClearDropTargets()
		{
		}

		private void ClearLockSlots()
		{
		}

		private void ClearLoadedLevelData()
		{
		}

		[IteratorStateMachine(typeof(_003CCreateLevelCoroutine_003Ed__86))]
		private IEnumerator CreateLevelCoroutine(LevelCreatorSaveData saveData, int index = 0)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CPlayStagePreview_003Ed__87))]
		private UniTask PlayStagePreview(LevelCreatorSaveData saveData)
		{
			return default(UniTask);
		}

		[AsyncStateMachine(typeof(_003CCreateStage_003Ed__88))]
		public UniTask CreateStage(LevelCreatorSaveData.StageData stageData, bool isPreview = false)
		{
			return default(UniTask);
		}

		private void SetDropTargetColors(List<int> colorIndexes)
		{
		}

		private void SetLevelType(LevelCreatorSaveData saveData)
		{
		}

		private void ShuffleMapAccordingPattern(List<PlayPattern> randomizationDataPatterns)
		{
		}

		private void RotateMap(bool rotate)
		{
		}

		private void MirrorFlip()
		{
		}

		private void SaveHighTensionRopes()
		{
		}

		[AsyncStateMachine(typeof(_003CMoveCameraOutOfMap_003Ed__95))]
		private UniTask MoveCameraOutOfMap(Transform cameras)
		{
			return default(UniTask);
		}

		[AsyncStateMachine(typeof(_003CMoveCameraBackToMap_003Ed__96))]
		private UniTask MoveCameraBackToMap(Transform cameras)
		{
			return default(UniTask);
		}

		[AsyncStateMachine(typeof(_003CMoveCameraBackToMapFromRight_003Ed__97))]
		private UniTask MoveCameraBackToMapFromRight(Transform cameras)
		{
			return default(UniTask);
		}

		[AsyncStateMachine(typeof(_003CMoveCameraOutOfMapToLeft_003Ed__98))]
		private UniTask MoveCameraOutOfMapToLeft(Transform cameras)
		{
			return default(UniTask);
		}

		public override void ResetLevel()
		{
		}

		private void ResetStage()
		{
		}

		[IteratorStateMachine(typeof(_003CCreateLevelInternal_003Ed__101))]
		protected override IEnumerator CreateLevelInternal(LevelCreatorSaveData saveData, int index = 0)
		{
			return null;
		}

		public void GetLevelSaveDataAsJson()
		{
		}

		public void UpdateCurrentStageFromScene()
		{
		}

		private void UpdateCurrentStageData(LevelCreatorSaveData.StageData stageData)
		{
		}

		private List<int> GetColorSaveData()
		{
			return null;
		}

		private List<PinData> GetPinsSaveData()
		{
			return null;
		}

		private List<RopeData> GetRopesSaveData()
		{
			return null;
		}

		private List<ColumnData> GetColumnsSaveData()
		{
			return null;
		}

		private List<ClampData> GetClampsSaveData()
		{
			return null;
		}

		private List<LiveObstacleData> GetLiveObstaclesSaveData()
		{
			return null;
		}

		private List<KeyData> GetKeysSaveData()
		{
			return null;
		}

		private List<LockSlotData> GetLockSlotsSaveData()
		{
			return null;
		}

		private List<GoldenRopeData> GetGoldenRopesSaveData()
		{
			return null;
		}

		private List<RopeWidthData> GetRopeWidthsSaveData()
		{
			return null;
		}

		public void DeleteStage()
		{
		}

		public void AddNewStage(LevelCreatorSaveData.StageData stage = null)
		{
		}

		public void SetCurrentStage(LevelCreatorData creatorData)
		{
		}

		public void CheckCurrentStageData()
		{
		}

		public void UpdateTargets(List<LevelCreatorSaveData.ColorTargetData> newColorTargets)
		{
		}
	}
}
