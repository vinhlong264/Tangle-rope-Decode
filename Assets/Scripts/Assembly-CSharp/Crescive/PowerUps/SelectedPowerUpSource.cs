using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

namespace Crescive.PowerUps
{
	[CreateAssetMenu(fileName = "Selected Power Up Source", menuName = "Crescive/Power Ups/Sources/Selected Power Up Source")]
	public class SelectedPowerUpSource : PowerUpSource
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass3_0
		{
			public PowerUpChannel powerUpChannel;

			internal bool _003CUsePowerUps_003Eb__0()
			{
				return false;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUsePowerUps_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

			public SelectedPowerUpSource _003C_003E4__this;

			public CancellationToken cancellationToken;

			private _003C_003Ec__DisplayClass3_0 _003C_003E8__1;

			private List<PowerUpChannel>.Enumerator _003C_003E7__wrap1;

			private UniTask<bool>.Awaiter _003C_003Eu__1;

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
		private PowerUpSystem powerUpSystem;

		[Header("Settings")]
		[SerializeField]
		private float delayBetweenPowerUps;

		public override IEnumerable<PowerUpChannel> GetReadyPowerUps()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CUsePowerUps_003Ed__3))]
		public override UniTask<bool> UsePowerUps(CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<bool>);
		}
	}
}
