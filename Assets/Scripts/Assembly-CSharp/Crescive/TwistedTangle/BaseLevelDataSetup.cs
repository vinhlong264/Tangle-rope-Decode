using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Crescive.CreatorMode;
using Crescive.HelperTypes;
using CresciveCore;
using Cysharp.Threading.Tasks;
using UnityAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public abstract class BaseLevelDataSetup : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCreateLevel_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public BaseLevelDataSetup _003C_003E4__this;

			private LevelCreatorSaveData _003ClevelData_003E5__2;

			private UniTask<LevelCreatorSaveData>.Awaiter _003C_003Eu__1;

			private UniTask.Awaiter _003C_003Eu__2;

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
		private List<AtomCondition> conditions;

		[SerializeField]
		private AutoTriggerMethod createTrigger;

		[SerializeField]
		private LevelCreatorChannel levelCreatorChannel;

		[SerializeField]
		protected LevelSystem levelSystem;

		private bool didCreateLevel;

		public UnityEvent OnLevelCreated;

		public UnityEvent<string> OnLevelCreatedWithJson;

		protected LevelCreator LevelCreator => null;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		public void TryLoadLevel()
		{
		}

		public void ResetState()
		{
		}

		protected abstract UniTask<LevelCreatorSaveData> GetLevelData();

		[AsyncStateMachine(typeof(_003CCreateLevel_003Ed__15))]
		private void CreateLevel()
		{
		}
	}
}
