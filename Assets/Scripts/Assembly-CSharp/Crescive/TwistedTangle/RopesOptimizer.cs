using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Crescive.Draggables;
using Crescive.Draggables.EventParams;
using Obi;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class RopesOptimizer : MonoBehaviour
	{
		[Serializable]
		public class RopeOptimizerData
		{
			public RopeEntity Rope;

			private RopePhysicToggler PhysicToggler => null;

			public bool Active
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public float Timer
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public bool HasTimeOut(float resetPeriod)
			{
				return false;
			}

			public RopeOptimizerData(RopeEntity rope)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CDeactivateAllRopesNumearator_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RopesOptimizer _003C_003E4__this;

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
			public _003CDeactivateAllRopesNumearator_003Ed__12(int _003C_003E1__state)
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
		private DraggablesControllerChannel draggablesControllerChannel;

		[SerializeField]
		private PinsTapMoveChannel pinsTapMoveChannel;

		[SerializeField]
		private DropTargetHoldersChannel holdersChannel;

		[SerializeField]
		private RopesChannel ropesChannel;

		[SerializeField]
		private ObiCollisionsChannel collisionsChannel;

		[SerializeField]
		private float resetPeriod;

		private float lastUpdateAllTime;

		[SerializeField]
		private List<RopeOptimizerData> optimizerData;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void FixedUpdate()
		{
		}

		private void DeactivateAllRopesInitially()
		{
		}

		[IteratorStateMachine(typeof(_003CDeactivateAllRopesNumearator_003Ed__12))]
		private IEnumerator DeactivateAllRopesNumearator()
		{
			return null;
		}

		private void OnSelectDraggable(DraggableEventParams args)
		{
		}

		private void OnDragDraggable(DraggableEventParams args)
		{
		}

		private void UpdateRopes()
		{
		}

		private void TryDeactivatingAllRopes()
		{
		}

		private void ActivateSelectedPinRopes()
		{
		}

		private void ActivatePlacingPinRopes()
		{
		}

		private PinEntity GetPin()
		{
			return null;
		}

		private void ActivateCollidingRopesRecursive(RopeEntity rope)
		{
		}

		private void ActivateCollidingRopes(List<RopeEntity> collidingRopes)
		{
		}

		private void DeactivateNotCollidingRopes()
		{
		}

		private void ActivateMergedRopes()
		{
		}

		private void SetRopeActive(RopeOptimizerData data, bool active)
		{
		}

		private void UpdateOptimizerData()
		{
		}

		private bool IsAnyDraggablePlacing()
		{
			return false;
		}

		private List<PinEntity> GetPlacingPins()
		{
			return null;
		}

		private List<RopeEntity> GetPlacingRopes()
		{
			return null;
		}

		public void TryActivateAllRopesAndRefreshTimer()
		{
		}

		public void DeactivateAllRopes()
		{
		}
	}
}
