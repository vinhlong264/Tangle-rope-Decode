using System.Collections.Generic;
using Crescive.DataService;
using UnityEngine;

namespace Crescive.NewLevelFeatures
{
	[CreateAssetMenu(fileName = "NewLevelFeaturesDataService", menuName = "Crescive/New Level Features/New Level Features Data Service")]
	public class NewLevelFeaturesDataService : DataReadService<NewLevelFeaturesData>
	{
		[SerializeField]
		private List<NewLevelFeatureGameData> featuresGameData;

		protected override NewLevelFeaturesData GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(NewLevelFeaturesData plainData)
		{
			return false;
		}

		public NewLevelFeatureGameData GetFirstGameDataIfExistsInList(List<int> levelNumbers)
		{
			return null;
		}
	}
}
