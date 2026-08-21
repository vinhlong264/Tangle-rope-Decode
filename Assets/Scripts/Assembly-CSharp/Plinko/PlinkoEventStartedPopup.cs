using Crescive.Navigation;
using Crescive.Sequencer;
using UnityEngine;
using UnityEngine.UI;

namespace Plinko
{
	public class PlinkoEventStartedPopup : MonoBehaviour
	{
		[SerializeField]
		private GameObject main;

		[SerializeField]
		private Navigatable navigatable;

		[SerializeField]
		private SequencerChannel returnedHomeSequencerChannel;

		[SerializeField]
		private Button continueButton;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnReturnedHome()
		{
		}

		public void OnContinueClicked()
		{
		}

		public void OpenUI()
		{
		}

		public void CloseUI()
		{
		}
	}
}
