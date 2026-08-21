using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.PowerUps
{
	[CreateAssetMenu(fileName = "Consecutive Win Power Up Source", menuName = "Crescive/Power Ups/Sources/Consecutive Win Power Up Source")]
	public class ConsecutiveWinPowerUpSource : PowerUpSource
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUsePowerUps_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

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

		[SerializeField]
		private StringReference powerUpRewardType;

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
