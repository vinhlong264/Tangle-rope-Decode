using Crescive.Ads;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.RaceSystem
{
	public class RaceOngoingPanelController : MonoBehaviour
	{
		[SerializeField]
		private RaceSystem raceSystem;

		[SerializeField]
		private CresciveAdsEvents cresciveAdsEvents;

		[field: SerializeField]
		[field: Space]
		public IntVariableInstancer RaceWinCondition { get; private set; }

		[field: SerializeField]
		public FloatVariableInstancer RaceFirstReward { get; private set; }

		[field: SerializeField]
		public FloatVariableInstancer RaceSecondReward { get; private set; }

		[field: SerializeField]
		public FloatVariableInstancer RaceThirdReward { get; private set; }

		[field: SerializeField]
		public FloatVariableInstancer RaceTimeRemainingMinutes { get; private set; }

		public void OnShow()
		{
		}

		public void OnHide()
		{
		}
	}
}
