using Crescive.Navigation;
using Crescive.Sequencer;
using UnityEngine;
using UnityEngine.UI;

namespace Plinko
{
	public class PlinkoEventEndedPopup : MonoBehaviour
	{
		[SerializeField]
		private GameObject main;

		[SerializeField]
		private Navigatable navigatable;

		[SerializeField]
		private SequencerChannel returnedHomeSequencerChannel;

		[SerializeField]
		private Button playButton;

		[SerializeField]
		private Button continueButton;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnContinueClicked()
		{
		}

		private void OnPlayClicked()
		{
		}

		private void OnReturnedHome()
		{
		}

		public void OpenUI(bool isLastChance)
		{
		}

		public void CloseUI()
		{
		}
	}
}
