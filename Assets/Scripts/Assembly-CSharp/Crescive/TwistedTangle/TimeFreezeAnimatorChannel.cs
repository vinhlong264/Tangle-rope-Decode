using Crescive.Channels;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	[CreateAssetMenu(fileName = "Time Freeze Animator Channel", menuName = "Crescive/Boosters/Channels/Time Freeze Animator Channel")]
	public class TimeFreezeAnimatorChannel : ObjectChannel<TimeFreezeAnimator>
	{
		public void AddFadeCanvasGroup(TimeFreezeFadeFx fadeFx)
		{
		}

		public void RemoveFadeCanvasGroup(TimeFreezeFadeFx canvasGroup)
		{
		}

		public void AddCountdownBar(TimeFreezeCountdownBar countdownBar)
		{
		}

		public void RemoveCountdownBar(TimeFreezeCountdownBar countdownBar)
		{
		}
	}
}
