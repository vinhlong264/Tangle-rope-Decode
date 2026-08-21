using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.RaceSystem
{
	public class RaceFinishedPanelController : MonoBehaviour
	{
		[SerializeField]
		private RaceSystem raceSystem;

		public UnityEvent<int> OnSetRank;

		public UnityEvent OnCompleteRace;

		[field: Space]
		[field: SerializeField]
		public IntVariableInstancer RaceRank { get; private set; }

		[field: SerializeField]
		public FloatVariableInstancer RaceReward { get; private set; }

		[field: SerializeField]
		public IntVariableInstancer RaceCompletion { get; private set; }

		public void OnShow()
		{
		}

		public void CompleteRace()
		{
		}
	}
}
