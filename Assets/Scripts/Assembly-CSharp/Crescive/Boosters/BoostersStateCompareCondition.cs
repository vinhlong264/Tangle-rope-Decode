using System.Collections.Generic;
using UnityAtoms;
using UnityEngine;

namespace Crescive.Boosters
{
	[CreateAssetMenu(menuName = "Crescive/Boosters/Conditions/Boosters State Compare Condition")]
	public class BoostersStateCompareCondition : AtomCondition
	{
		[SerializeField]
		private BoosterSystem boosterSystem;

		[SerializeField]
		private List<BoosterStateCompareData> comparisons;

		public override bool Call()
		{
			return false;
		}
	}
}
