using CresciveCore;
using UnityAtoms;
using UnityEngine;

namespace Crescive.ReturnHome
{
	[CreateAssetMenu(menuName = "Crescive/Return Home/Return Home Level Reached Atom Condition", fileName = "ReturnHomeLevelReachedAtomCondition")]
	public class ReturnHomeLevelReachedAtomCondition : AtomCondition
	{
		[SerializeField]
		private LevelSystem levelSystem;

		[SerializeField]
		private ReturnHomeDataService service;

		public override bool Call()
		{
			return false;
		}
	}
}
