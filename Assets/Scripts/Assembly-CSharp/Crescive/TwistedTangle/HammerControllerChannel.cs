using Crescive.Channels;
using CresciveCore;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	[CreateAssetMenu(fileName = "Hammer Controller Channel", menuName = "Crescive/Power Ups/Hammer/Hammer Controller Channel")]
	public class HammerControllerChannel : ObjectChannel<HammerController>
	{
		public UnityEvent<PinEntity> OnPinChosen;

		public LevelSystem levelSystem;
	}
}
