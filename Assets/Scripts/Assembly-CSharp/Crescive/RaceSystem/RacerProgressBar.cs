using BrunoMikoski.AnimationSequencer;
using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.RaceSystem
{
	public class RacerProgressBar : MonoBehaviour
	{
		[SerializeField]
		private Slider progressSlider;

		[SerializeField]
		private TMP_Text rankText;

		[SerializeField]
		private UIImageSetter rankImageSetter;

		[Space]
		[SerializeField]
		private IntVariableInstancer raceCompletion;

		[Header("Settings")]
		[SerializeField]
		private float sliderUpdateDuration;

		[SerializeField]
		private float sliderUpdateDelay;

		[SerializeField]
		private CustomEase sliderUpdateEase;

		[SerializeField]
		private string racerId;

		[SerializeField]
		private int completion;

		[SerializeField]
		private int rank;

		public string RacerId => null;

		public int Completion => 0;

		public int Rank => 0;

		private void OnEnable()
		{
		}

		private void SyncStateToInstancers()
		{
		}

		public void Initialize(RacerData racer, int winCondition)
		{
		}

		public void UpdateData(int newCompletion, int newRank, bool resetSlider)
		{
		}

		public void UpdateSlider(bool animated)
		{
		}
	}
}
