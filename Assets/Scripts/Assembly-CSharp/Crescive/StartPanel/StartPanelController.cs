using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Crescive.Layout;
using Cysharp.Threading.Tasks;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.StartPanel
{
	public class StartPanelController : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCheckPlayingOnLeagueAsync_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public StartPanelController _003C_003E4__this;

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

		[Header("References")]
		[SerializeField]
		private SimpleScrollSnapPageController scrollSnapPageController;

		[SerializeField]
		private AtomCondition isPlayingOnLeague;

		[Header("Panel Keys")]
		[SerializeField]
		private StringReference chapterLevelsPanelKey;

		[SerializeField]
		private StringReference leagueLevelsPanelKey;

		private bool _playingOnLeague;

		private bool _leagueFinished;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		[AsyncStateMachine(typeof(_003CCheckPlayingOnLeagueAsync_003Ed__8))]
		private void CheckPlayingOnLeagueAsync()
		{
		}

		public void CheckPlayingOnLeague()
		{
		}
	}
}
