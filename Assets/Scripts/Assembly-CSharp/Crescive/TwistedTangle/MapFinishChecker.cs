using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Crescive.Draggables;
using Crescive.HelperTypes;
using Crescive.Levels;
using Obi;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public class MapFinishChecker : MonoBehaviour
	{
		[SerializeField]
		private RopesChannel ropesChannel;

		[SerializeField]
		private DropTargetHoldersChannel holdersChannel;

		[SerializeField]
		private ObiCollisionsChannel collisionsChannel;

		[SerializeField]
		private LoadedLevelDataChannel loadedLevelDataChannel;

		[SerializeField]
		private float successCheckDelay;

		[SerializeField]
		private bool useFixedDeltaTime;

		[SerializeField]
		private BoolReference mergeOnAir;

		[SerializeField]
		private List<BoolVariableReference> disableCheckConditions;

		[SerializeField]
		private BoolReference isStagedLevel;

		[SerializeField]
		private IntReference stagedLevelIndex;

		public UnityEvent OnSuccess;

		public UnityEvent<RopeCollideData> OnRopeStartMerge;

		public UnityEvent<RopeCollideData> OnRopeStartMergeOnPlace;

		public UnityEvent<RopeCollideData> OnRopeStartMergeOnAir;

		[SerializeField]
		private bool ropesColliding;

		private bool succeeded;

		private float successCheckTimer;

		[SerializeField]
		private List<RopeCollideData> ropeCollidingData;

		private float DeltaTime => 0f;

		private bool HasNotMergedFreeRopes => false;

		private bool HasAnyRopesColliding => false;

		public static event Action StageLevelMapStageCleared
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action MapStageCleared
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Update()
		{
		}

		private void CutAllRopes()
		{
		}

		private void FixedUpdate()
		{
		}

		private void CheckMap()
		{
		}

		private void MergeRopes()
		{
		}

		private void MergeRope(RopeCollideData data)
		{
		}

		private void CheckSuccess()
		{
		}

		private void Success()
		{
		}

		private List<RopeCollideData> GetMergeableRopesData()
		{
			return null;
		}

		private List<RopeCollideData> GetCollidingRopesData()
		{
			return null;
		}

		private bool IsRopeMergeable(RopeCollideData data)
		{
			return false;
		}

		private bool IsRopePinsPlaced(RopeCollideData data)
		{
			return false;
		}

		private bool IsRopeColliding(RopeCollideData data)
		{
			return false;
		}

		private void UpdateRopesCollideData()
		{
		}

		private void UpdateRopesTimerData()
		{
		}

		private void SetRopesColliding(bool value)
		{
		}

		public void ResetState()
		{
		}
	}
}
