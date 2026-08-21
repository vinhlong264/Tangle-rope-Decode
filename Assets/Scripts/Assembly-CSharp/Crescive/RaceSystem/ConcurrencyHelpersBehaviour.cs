using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RSG;
using UnityEngine;

namespace Crescive.RaceSystem
{
	public class ConcurrencyHelpersBehaviour : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDelayedFramesCallRoutine_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public int frames;

			public Action callback;

			public IPendingPromise promise;

			private int _003Ci_003E5__2;

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
			public _003CDelayedFramesCallRoutine_003Ed__6(int _003C_003E1__state)
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
		private sealed class _003CForEachRoutine_003Ed__4<T> : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public bool waitNextFrame;

			public Action<T, int> onIterated;

			public IList<T> items;

			public ConcurrencyHelpersBehaviour _003C_003E4__this;

			public IPendingPromise promise;

			private int _003Ci_003E5__2;

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
			public _003CForEachRoutine_003Ed__4(int _003C_003E1__state)
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
		private sealed class _003CInstantiateRoutine_003Ed__2<T> : IEnumerator<object>, IEnumerator, IDisposable where T : Component
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Func<int, T> prefabGetter;

			public Transform parent;

			public Action<T, int> onSpawned;

			public int count;

			public ConcurrencyHelpersBehaviour _003C_003E4__this;

			public IPendingPromise promise;

			private int _003Ci_003E5__2;

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
			public _003CInstantiateRoutine_003Ed__2(int _003C_003E1__state)
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
		private float interval;

		public IPromise Instantiate<T>(int count, Transform parent, Func<int, T> prefabGetter, Action<T, int> onSpawned) where T : Component
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CInstantiateRoutine_003Ed__2<>))]
		private IEnumerator InstantiateRoutine<T>(int count, Transform parent, Func<int, T> prefabGetter, Action<T, int> onSpawned, IPendingPromise promise) where T : Component
		{
			return null;
		}

		public IPromise ForEach<T>(IList<T> items, Action<T, int> onIterated, bool waitNextFrame = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CForEachRoutine_003Ed__4<>))]
		private IEnumerator ForEachRoutine<T>(IList<T> items, Action<T, int> onIterated, bool waitNextFrame, IPendingPromise promise)
		{
			return null;
		}

		public IPromise DelayedFramesCall(int frames, Action callback)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDelayedFramesCallRoutine_003Ed__6))]
		private IEnumerator DelayedFramesCallRoutine(IPendingPromise promise, int frames, Action callback)
		{
			return null;
		}
	}
}
