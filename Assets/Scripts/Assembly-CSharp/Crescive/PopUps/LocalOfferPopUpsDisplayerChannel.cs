using Crescive.Channels;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.PopUps
{
	[CreateAssetMenu(fileName = "Local Offer Pop Ups Displayer Channel", menuName = "Crescive/Offer/Local Offer Pop Ups Displayer Channel")]
	public class LocalOfferPopUpsDisplayerChannel : ObjectChannel<LocalOfferPopUpsDisplayer>
	{
		public UnityEvent<bool> OnDisplayPopUpsResult => null;
	}
}
