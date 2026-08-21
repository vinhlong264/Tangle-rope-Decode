using UnityEngine;
using UnityEngine.Events;

namespace Crescive.FeedbackPopUp
{
	[CreateAssetMenu(fileName = "Tap Blocker Events", menuName = "Crescive/UI/Tap Blocker/Tap Blocker Events")]
	public class TapBlockerEvents : ScriptableObject
	{
		public UnityEvent OnBlock;

		public UnityEvent OnUnblock;

		public void Block()
		{
		}

		public void Unblock()
		{
		}
	}
}
