using System;
using System.Collections.Generic;
using UnityEngine;

namespace Crescive.PowerUps
{
	[Serializable]
	public class PowerUpGroup
	{
		[SerializeField]
		private List<PowerUpChannel> powerUps;

		public List<PowerUpChannel> PowerUps => null;
	}
}
