using Crescive.Channels;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Boosters
{
	[CreateAssetMenu(fileName = "Booster Buttons Controller Channel", menuName = "Crescive/Boosters/Channels/Booster Buttons Controller Channel")]
	public class BoosterButtonsControllerChannel : ObjectChannel<BoosterButtonsController>
	{
		public UnityEvent OnSetupDone;
	}
}
