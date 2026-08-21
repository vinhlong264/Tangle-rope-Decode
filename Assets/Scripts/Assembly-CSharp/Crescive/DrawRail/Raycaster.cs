using System;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.DrawRail
{
	public class Raycaster : MonoBehaviour
	{
		[SerializeField]
		private Transform rayPos;

		[SerializeField]
		private Vector3 rayDir;

		[SerializeField]
		private LayerMask layer;

		[SerializeField]
		private Color gizmosColor;

		[SerializeField]
		private bool drawGizmosAlways;

		[SerializeField]
		private float rayDistance;

		[SerializeField]
		private int maxHits;

		[SerializeField]
		private bool triggerUnityEvents;

		[SerializeField]
		private bool raycastEveryFrame;

		public UnityEvent OnFind;

		public UnityEvent OnLost;

		private RaycastHit[] hits;

		private NativeArray<RaycastCommand> raycastCommands;

		private NativeArray<RaycastHit> raycastHits;

		private JobHandle jobHandle;

		private int raycastHitCount;

		private bool hasPreviousHits;

		private RaycastHit _firstHit;

		private RaycastHit _lastHit;

		public int RaycastHitCount => 0;

		public RaycastHit[] Hits => null;

		public RaycastHit FirstHit => default(RaycastHit);

		public RaycastHit LastHit => default(RaycastHit);

		public bool HasHit => false;

		public float RayDistance => 0f;

		public event Action OnFindEvent
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

		public event Action OnLostEvent
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

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void AllocateArrays()
		{
		}

		private void DeallocateArrays()
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}

		private void OnDrawGizmos()
		{
		}

		private void DrawGizmos()
		{
		}

		private void ReadBufferAndUpdateHits()
		{
		}

		private RaycastCommand CreateRaycastCommand(Vector3 origin, Vector3 direction)
		{
			return default(RaycastCommand);
		}

		private void TriggerOnFindEvents()
		{
		}

		private void TriggerOnLostEvents()
		{
		}

		public bool PerformRaycast()
		{
			return false;
		}
	}
}
