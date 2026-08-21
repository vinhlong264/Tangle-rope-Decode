using Crescive.GameStates;
using Crescive.TwistedTangle;
using CresciveCore;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.LiveEvents.DynamicQuest
{
	public class DynamicQuestPendingTokensController : MonoBehaviour
	{
		[SerializeField]
		private DynamicQuestSystem system;

		[SerializeField]
		private GameStateEvents gameStateEvents;

		[SerializeField]
		private IntReference collectedTokens;

		[SerializeField]
		private LoaderChannel loaderChannel;

		[SerializeField]
		private RopesChannel ropesChannel;

		private float multiplierAmount;

		public UnityEvent<Vector3> OnTokensIncreased;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void IncreaseTokens(Vector3 point)
		{
		}

		private void IncreaseTokensRemainingRopes()
		{
		}

		private void ResetProgress()
		{
		}

		private void ResetMultiplier()
		{
		}

		private void LoadLastLeveRequestedCallback()
		{
		}

		private void OnPlay()
		{
		}

		private void OnWin()
		{
		}
	}
}
