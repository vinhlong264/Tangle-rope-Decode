using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.CreatorMode
{
	public abstract class BaseLevelSaver<TCreatorData, TSaveData> : BaseSaver where TCreatorData : BaseLevelCreatorData<TSaveData>
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSaveLevel_003Ed__5 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public BaseLevelSaver<TCreatorData, TSaveData> _003C_003E4__this;

			public BaseCreatorData data;

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

		[CompilerGenerated]
		private sealed class _003CSaveLevelImageCoroutine_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

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
			public _003CSaveLevelImageCoroutine_003Ed__3(int _003C_003E1__state)
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

		[Space(5f)]
		[Header("Settings")]
		[Range(0f, 1f)]
		[SerializeField]
		private float screenshotResolutionScale;

		public UnityEvent OnSaveLevelStarted;

		public abstract TSaveData GetLevelSaveData();

		[IteratorStateMachine(typeof(BaseLevelSaver<, >._003CSaveLevelImageCoroutine_003Ed__3))]
		private IEnumerator SaveLevelImageCoroutine(BaseCreatorData data)
		{
			return null;
		}

		public override string GetLevelSaveDataAsJson()
		{
			return null;
		}

		[AsyncStateMachine(typeof(BaseLevelSaver<, >._003CSaveLevel_003Ed__5))]
		public override UniTask SaveLevel(BaseCreatorData data)
		{
			return default(UniTask);
		}

		public void SaveLevelAsNew()
		{
		}
	}
}
