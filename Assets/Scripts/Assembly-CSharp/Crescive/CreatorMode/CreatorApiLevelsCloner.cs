using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Crescive.CreatorMode
{
	public class CreatorApiLevelsCloner : MonoBehaviour
	{
		[Serializable]
		private class LevelsUpdateConfig
		{
			public List<string> LevelIds;

			public List<LevelUpdateData> LevelsUpdateData;

			public void ExpandLevelsUpdateDataIfNeeded()
			{
			}
		}

		[Serializable]
		private class LevelUpdateData
		{
			public bool UpdateTime;

			public int Time;

			public bool UpdateDifficulty;

			public string Difficulty;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCloneLevels_003Ed__5 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public CreatorApiLevelsCloner _003C_003E4__this;

			private int _003Ci_003E5__2;

			private UniTask<CreatorModeAPI.Models.LevelModel>.Awaiter _003C_003Eu__1;

			private UniTask<string>.Awaiter _003C_003Eu__2;

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
		private CreatorApiRequestLevelIntegration levelIntegration;

		[SerializeField]
		private LevelsUpdateConfig levelsUpdateConfig;

		[SerializeField]
		private List<string> clonedLevelIds;

		private LevelCreatorSaveData UpdateLevelData(LevelCreatorSaveData levelData, int i)
		{
			return null;
		}

		public void CopyClonedLevelsToClipboard()
		{
		}

		[AsyncStateMachine(typeof(_003CCloneLevels_003Ed__5))]
		public void CloneLevels()
		{
		}

		private void SetLevelIdsFromClipboard()
		{
		}

		private void SetDifficultiesFromClipboard()
		{
		}

		private void SetTimesFromClipboard()
		{
		}
	}
}
