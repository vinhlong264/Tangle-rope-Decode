using Crescive.DataService;

namespace Game.Scripts.Shop.Logic
{
	public class MainShopFilterDataService : DataReadService<MainShopFilterData>
	{
		protected override MainShopFilterData GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(MainShopFilterData plainData)
		{
			return false;
		}
	}
}
