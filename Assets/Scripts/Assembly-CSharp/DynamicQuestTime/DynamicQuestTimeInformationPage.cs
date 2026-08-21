using Crescive.Navigation;
using Crescive.Sequencer;
using UnityEngine;

namespace DynamicQuestTime
{
	public class DynamicQuestTimeInformationPage : MonoBehaviour
	{
		[SerializeField]
		private GameObject main;

		[SerializeField]
		private Navigatable navigatable;

		[SerializeField]
		private SequencerChannel returnedHomeSequencerChannel;

		[SerializeField]
		private GameObject playButton;

		[SerializeField]
		private GameObject continueButton;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnInfoButtonClicked(DynamicQuestTimeEvents.OnInfoButtonClicked p)
		{
		}

		private void OnReturnedHome()
		{
		}

		public void OnContinueClicked()
		{
		}

		public void OpenUI(bool isInfo)
		{
		}

		public void CloseUI()
		{
		}
	}
}
