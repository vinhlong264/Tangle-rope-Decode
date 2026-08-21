using Crescive.DataService;
using CresciveCore;
using UnityEngine;

namespace Crescive.PowerUps
{
	[CreateAssetMenu(fileName = "Power Up Settings Data Service", menuName = "Crescive/Power Ups/Services/Power Up Settings Data Service")]
	public class PowerUpSettingsDataService : BaseDataWithJsonDataReadService<PowerUpSettingsData>
	{
		[SerializeField]
		[Header("Booster")]
		private LevelSystem levelSystem;

		public bool DidReachMinLevel => false;

		protected override PowerUpSettingsData GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(PowerUpSettingsData plainData)
		{
			return false;
		}
	}
}
