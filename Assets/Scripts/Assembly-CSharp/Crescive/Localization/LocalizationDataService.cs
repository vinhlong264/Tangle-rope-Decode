using Crescive.DataService;
using UnityEngine;

namespace Crescive.Localization
{
	[CreateAssetMenu(fileName = "Localization Data Service", menuName = "Crescive/Localization/Service/Localization Data Service")]
	public class LocalizationDataService : DataReadService<LocalizationData>
	{
		protected override LocalizationData GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(LocalizationData plainData)
		{
			return false;
		}

		public bool IsLocaleEnabled(string locale)
		{
			return false;
		}
	}
}
