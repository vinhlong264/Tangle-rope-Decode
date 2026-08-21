using System.Collections.Generic;
using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Crescive.PowerUps
{
	public abstract class PowerUpSource : ScriptableObject
	{
		public abstract IEnumerable<PowerUpChannel> GetReadyPowerUps();

		public abstract UniTask<bool> UsePowerUps(CancellationToken cancellationToken = default(CancellationToken));
	}
}
