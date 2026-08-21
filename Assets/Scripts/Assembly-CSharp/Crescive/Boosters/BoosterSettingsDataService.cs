using Crescive.DataService;
using CresciveCore;
using UnityEngine;

namespace Crescive.Boosters
{
	[CreateAssetMenu(fileName = "Booster Settings Data Service", menuName = "Crescive/Boosters/Services/Booster Settings Data Service")]
	public class BoosterSettingsDataService : BaseDataWithJsonDataReadService<BoosterSettingsData>
	{
		[SerializeField]
		[Header("Booster")]
		private LevelSystem levelSystem;

		public bool DidReachMinLevel => false;

		protected override BoosterSettingsData GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(BoosterSettingsData plainData)
		{
			return false;
		}
	}
}
