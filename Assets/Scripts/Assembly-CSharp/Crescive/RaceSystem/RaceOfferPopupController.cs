using Crescive.PopUps;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.RaceSystem
{
	public class RaceOfferPopupController : MonoBehaviour
	{
		[SerializeField]
		private OfferPopUp offerPopUp;

		[SerializeField]
		private RaceSystem raceSystem;

		[SerializeField]
		private GameObject racePanel;

		[SerializeField]
		private GameObject metaRacePanel;

		private bool _shownBuyEvent;

		[field: SerializeField]
		[field: Space]
		public IntVariableInstancer RaceWinCondition { get; private set; }

		[field: SerializeField]
		public FloatVariableInstancer RaceWinnerReward { get; private set; }

		[field: SerializeField]
		public FloatVariableInstancer RaceTimeRemainingMinutes { get; private set; }

		public void OnShow()
		{
		}

		public void OnApprove()
		{
		}

		public void OnDecline()
		{
		}

		public void ShowBuyEvent()
		{
		}
	}
}
