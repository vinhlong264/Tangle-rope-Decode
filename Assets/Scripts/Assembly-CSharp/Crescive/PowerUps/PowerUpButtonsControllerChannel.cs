using Crescive.Channels;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.PowerUps
{
	[CreateAssetMenu(fileName = "Power Up Buttons Controller Channel", menuName = "Crescive/Power Ups/Channels/Power Up Buttons Controller Channel")]
	public class PowerUpButtonsControllerChannel : ObjectChannel<PowerUpButtonsController>
	{
		public UnityEvent OnSetupDone;
	}
}
