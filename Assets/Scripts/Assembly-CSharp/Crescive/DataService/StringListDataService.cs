using UnityEngine;

namespace Crescive.DataService
{
	[CreateAssetMenu(fileName = "String List Data Service", menuName = "Crescive/Data Service/Types/String List/String List Data Service")]
	public class StringListDataService : DataReadService<StringList>
	{
		protected override StringList GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(StringList plainData)
		{
			return false;
		}
	}
}
