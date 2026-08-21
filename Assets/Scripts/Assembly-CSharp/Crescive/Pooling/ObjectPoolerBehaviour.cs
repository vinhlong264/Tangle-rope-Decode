using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Crescive.Pooling
{
	[DefaultExecutionOrder(-100000)]
	public class ObjectPoolerBehaviour : MonoBehaviour, IObjectPooler
	{
		public enum InitType
		{
			Awake = 0,
			Start = 1,
			OnEnable = 2
		}

		[CompilerGenerated]
		private sealed class _003CDespawnDelayedCoroutine_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float duration;

			public ObjectPoolerBehaviour _003C_003E4__this;

			public GameObject obj;

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
			public _003CDespawnDelayedCoroutine_003Ed__19(int _003C_003E1__state)
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
		private bool hasScriptableDelegate;

		[SerializeField]
		private ObjectPoolerScriptableDelegate scriptableDelegate;

		[SerializeField]
		private GameObjectPooler.PoolItem poolItem;

		[SerializeField]
		private Transform poolParent;

		[SerializeField]
		private bool autoInitialize;

		[SerializeField]
		private float defaultAutoDespawnTime;

		[SerializeField]
		private bool alwaysAutoDespawn;

		[SerializeField]
		private InitType initType;

		private GameObjectPooler pooler;

		private GameObjectPooler.PoolItem PoolItem => default(GameObjectPooler.PoolItem);

		public GameObject Prefab => null;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void InitPooler()
		{
		}

		private void InitScriptableDelegate()
		{
		}

		[IteratorStateMachine(typeof(_003CDespawnDelayedCoroutine_003Ed__19))]
		private IEnumerator DespawnDelayedCoroutine(GameObject obj, float duration)
		{
			return null;
		}

		public void Initialize(bool force = false)
		{
		}

		public GameObject Spawn()
		{
			return null;
		}

		public T Spawn<T>() where T : Component
		{
			return null;
		}

		public GameObject SpawnWithAutoDespawn(float? despawnDuration = null)
		{
			return null;
		}

		public void SpawnWithAutoDespawnDefault()
		{
		}

		public void SpawnAtWithAutoDespawn(Vector3 pos)
		{
		}

		public void SpawnAtWithAutoDespawn(Vector3 pos, float duration)
		{
		}

		public void Despawn(GameObject obj)
		{
		}

		public void Despawn<T>(T obj) where T : Component
		{
		}

		public void DespawnDelayed(GameObject obj, float despawnDuration)
		{
		}

		public void DespawnAll()
		{
		}

		public bool IsObjectFromPool(GameObject gameObject)
		{
			return false;
		}
	}
}
