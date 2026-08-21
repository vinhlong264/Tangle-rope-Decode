using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Crescive.Levels;
using UnityEngine;

namespace Crescive.CreatorMode
{
	public class CreatorApiOrderedLevelsUploader : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUploadLevels_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public CreatorApiOrderedLevelsUploader _003C_003E4__this;

			public int maxCount;

			private List<LevelCreatorData> _003Clevels_003E5__2;

			private int _003Ccount_003E5__3;

			private int _003Ci_003E5__4;

			private object _003C_003Eu__1;

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
		private string baseUrl;

		[SerializeField]
		private LevelFunnelData funnelData;

		[SerializeField]
		private List<string> uploadedLevelIds;

		[AsyncStateMachine(typeof(_003CUploadLevels_003Ed__3))]
		private void UploadLevels(int maxCount = 99999)
		{
		}

		private void CopyLevelIdsToClipboard()
		{
		}
	}
}
