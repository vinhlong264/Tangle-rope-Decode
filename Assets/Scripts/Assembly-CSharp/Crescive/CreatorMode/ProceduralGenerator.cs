using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Crescive.TwistedTangle;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.CreatorMode
{
	public class ProceduralGenerator : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CGenerateLevelCoroutine_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ProceduralGenerator _003C_003E4__this;

			private LevelCreator _003Ccreator_003E5__2;

			private LevelCreatorSaveData _003CcurrentData_003E5__3;

			private int _003Cindex_003E5__4;

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
			public _003CGenerateLevelCoroutine_003Ed__22(int _003C_003E1__state)
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

		[SerializeField]
		private List<LevelCreatorData> levelPool;

		[SerializeField]
		private LevelCreatorChannel creatorChannel;

		[SerializeField]
		private LevelSaverChannel saverChannel;

		[SerializeField]
		private MapProfileData mapProfileData;

		[SerializeField]
		private PinSlotsChannel slotsChannel;

		[SerializeField]
		private FloatReference minFillPercentage;

		[SerializeField]
		private FloatReference maxFillPercentage;

		private List<LevelCreatorSaveData.StageData> GetValidStagesOfSameMapId(LevelCreatorSaveData.StageData currentLevelData)
		{
			return null;
		}

		private List<RopeWithPinsData> GetAvailableRopesWithPins(LevelCreatorSaveData.StageData currentStageData, LevelCreatorSaveData.LevelData currentLevelData)
		{
			return null;
		}

		private List<RopeWithPinsData> GetAvailableRopesWithPins(LevelCreatorSaveData.StageData source, LevelCreatorSaveData.StageData current)
		{
			return null;
		}

		private RopeWithPinsData GetRandomRopeWithPins(LevelCreatorSaveData.StageData currentStageData, LevelCreatorSaveData.LevelData currentLevelData)
		{
			return null;
		}

		private List<PinSlotEntity> GetOccupiedSlotsInData(LevelCreatorSaveData.StageData data)
		{
			return null;
		}

		private List<Vector3> GetOccupiedSlotsPositionsInData(LevelCreatorSaveData.StageData data)
		{
			return null;
		}

		private List<PinSlotEntity> GetAvailableSlotsInData(LevelCreatorSaveData.StageData data)
		{
			return null;
		}

		private List<Vector3> GetAllSlotPositions()
		{
			return null;
		}

		private bool IsMapFilledEnough(LevelCreatorSaveData.StageData data, List<Vector3> slotsPositions, float targetFillPercentage)
		{
			return false;
		}

		private void GenerateMapProfileData(LevelCreatorSaveData.StageData data, LevelCreatorSaveData.StageData currentData)
		{
		}

		private void GenerateMoveCount(LevelCreatorSaveData data, LevelCreatorSaveData currentData)
		{
		}

		private void GenerateTimeLimit(LevelCreatorSaveData data, LevelCreatorSaveData currentData)
		{
		}

		private void GenerateColorSettings(LevelCreatorSaveData data, LevelCreatorSaveData currentData)
		{
		}

		private void GenerateRopesAndPins(LevelCreatorSaveData.StageData currentStageData, LevelCreatorSaveData.LevelData currentLevelData)
		{
		}

		private LevelCreatorSaveData GenerateData(LevelCreatorSaveData currentData, int index)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGenerateLevelCoroutine_003Ed__22))]
		private IEnumerator GenerateLevelCoroutine()
		{
			return null;
		}

		public void GenerateLevel()
		{
		}
	}
}
