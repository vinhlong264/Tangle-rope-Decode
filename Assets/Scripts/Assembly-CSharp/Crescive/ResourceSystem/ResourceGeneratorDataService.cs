using Crescive.DataService;
using UnityEngine;

namespace Crescive.ResourceSystem
{
	[CreateAssetMenu(fileName = "ResourceGeneratorDataService", menuName = "Crescive/ResourceSystem/Generator/ResourceGeneratorDataService")]
	public class ResourceGeneratorDataService : DataReadService<ResourceGeneratorData>
	{
		protected override ResourceGeneratorData GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(ResourceGeneratorData plainData)
		{
			return false;
		}
	}
}
