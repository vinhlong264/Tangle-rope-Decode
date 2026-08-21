using System;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Boosters
{
	[Serializable]
	public class BoosterStateCompareData
	{
		[SerializeField]
		private BoosterState state;

		[SerializeField]
		private bool isNot;

		[SerializeField]
		private BoosterCompareStrategy compareStrategy;

		public BoolCompareOperator compareOperator;

		[SerializeField]
		private BoosterChannel booster;

		[SerializeField]
		private List<BoosterChannel> excludedBoosters;

		public bool Compare(BoosterSystem boosterSystem)
		{
			return false;
		}
	}
}
