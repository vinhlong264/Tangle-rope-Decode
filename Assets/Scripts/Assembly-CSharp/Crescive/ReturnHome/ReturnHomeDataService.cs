using Crescive.DataService;
using UnityEngine;

namespace Crescive.ReturnHome
{
	[CreateAssetMenu(menuName = "Crescive/Return Home/DataService/ReturnHomeDataService", fileName = "ReturnHomeDataService")]
	public class ReturnHomeDataService : DataReadService<ReturnHomeData>
	{
		protected override ReturnHomeData GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(ReturnHomeData plainData)
		{
			return false;
		}
	}
}
