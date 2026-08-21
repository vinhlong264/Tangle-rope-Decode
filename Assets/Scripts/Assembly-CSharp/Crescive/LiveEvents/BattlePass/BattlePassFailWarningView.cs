using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.LiveEvents.BattlePass
{
	public class BattlePassFailWarningView : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI tokenProgressBarText;

		[SerializeField]
		private TextMeshProUGUI tokenProgressBarCurrentStepText;

		[SerializeField]
		private Slider tokenProgressBarSlider;

		[SerializeField]
		private TextMeshProUGUI tokenProgressBonusCaseText;

		[SerializeField]
		private GameObject tokenProgressStepParentObject;

		[SerializeField]
		private GameObject tokenProgressBonusCaseParentObject;

		[SerializeField]
		private BattlePassSystem battlePassSystem;

		private void OnEnable()
		{
		}

		public void Setup()
		{
		}
	}
}
