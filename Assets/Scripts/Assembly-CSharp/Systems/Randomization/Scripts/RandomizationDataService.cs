using Crescive.DataService;
using UnityEngine;

namespace Systems.Randomization.Scripts
{
	[CreateAssetMenu(fileName = "RandomizationDataService", menuName = "Crescive/Randomization/DataService/Randomization Service")]
	public class RandomizationDataService : DataReadService<RandomizationData>
	{
		protected override RandomizationData GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(RandomizationData plainData)
		{
			return false;
		}

		public RandomizationData? GetConfig()
		{
			return null;
		}
	}
}
