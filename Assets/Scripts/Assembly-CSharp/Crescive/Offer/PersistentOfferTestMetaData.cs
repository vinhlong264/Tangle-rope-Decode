using PersistentSO;
using UnityEngine;

namespace Crescive.Offer
{
	[CreateAssetMenu(fileName = "Persistent Offer Test Meta Data", menuName = "Crescive/Offer/Persistent Offer Test Meta Data")]
	public class PersistentOfferTestMetaData : PersistentVariable<OfferTestMetaData>
	{
		public override OfferTestMetaData GetCopy(OfferTestMetaData value)
		{
			return null;
		}
	}
}
