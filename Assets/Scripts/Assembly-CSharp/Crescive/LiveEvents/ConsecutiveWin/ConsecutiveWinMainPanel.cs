using Crescive.LiveEvents.SuperPowerup;
using Crescive.Navigation;
using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.LiveEvents.ConsecutiveWin
{
	[RequireComponent(typeof(Navigatable))]
	public class ConsecutiveWinMainPanel : MonoBehaviour
	{
		[SerializeField]
		private PersistentConsecutiveWinSaveData PersistentConsecutiveWinData;

		[SerializeField]
		private SuperPowerupDataService ConsecutiveWinConfig;

		[SerializeField]
		private GameObject infoWithMultipleStepsView;

		[SerializeField]
		private GameObject inProgressDescriptionTextObject;

		[SerializeField]
		private GameObject activeDescriptionTextObject;

		[SerializeField]
		private TextMeshProUGUI progressText;

		[SerializeField]
		private Slider progressSlider;

		[SerializeField]
		private IntReference winCountToClaimRewardReference;

		private Navigatable _navigatable;

		private Navigatable Navigatable => null;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Setup()
		{
		}

		public void OpenInfoPivot()
		{
		}

		public void CloseInfoPivot()
		{
		}
	}
}
