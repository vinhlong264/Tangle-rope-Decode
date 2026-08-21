using System;
using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Boosters
{
	[Serializable]
	public class BoosterGroup
	{
		[SerializeField]
		private List<BoosterChannel> boosters;

		public List<BoosterChannel> Boosters => null;
	}
}
