using BrunoMikoski.AnimationSequencer;
using UnityEngine;

namespace Crescive.LiveEvents.DynamicQuest
{
	public class DynamicQuestTokenClaimFx : MonoBehaviour
	{
		[SerializeField]
		private DynamicQuestSystem system;

		[SerializeField]
		private DynamicQuestTokenView tokenView;

		[SerializeField]
		private AnimationSequencerController multiplicationAnimation;

		[SerializeField]
		private Color multipliedAmountColor;

		public CanvasGroup CanvasGroup => null;

		public void Setup(int amount)
		{
		}

		public void MultiplyAndPlayAnimation()
		{
		}

		public void PlayAnimation()
		{
		}
	}
}
