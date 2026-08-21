using Crescive.Offer;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.PopUps
{
	public class LevelEndGoldClaimedOfferLogic : MonoBehaviour
	{
		[SerializeField]
		private VoidBaseEventReference onLevelEndGoldClaimed;

		[SerializeField]
		private OfferControllerChannel offerControllerChannel;

		[SerializeField]
		private LocalOfferPopUpsDisplayerChannel localOfferPopUpsDisplayerChannel;

		[SerializeField]
		private NavigatableStackPopUpCanShowCondition canShowCondition;

		[SerializeField]
		private UnityEvent OnPopupShow;

		[SerializeField]
		private UnityEvent OnNoPopUpAvailable;

		private int listenedEventsCount;

		private void TriggerOnPopUpShow()
		{
		}

		private void TryTriggerOnNoPopUpAvailable()
		{
		}

		private void SubscribeToOfferEvents()
		{
		}

		private void LogObjects()
		{
		}

		private void UnsubscribeFromOfferControllerEvents()
		{
		}

		private void OnOfferRequestResultCallback(OfferDataWrapper offerDataWrapper)
		{
		}

		private void OnDisplayPopupsResultCallback(bool hasPopUps)
		{
		}

		public void TryShowFirstAvailablePopup()
		{
		}
	}
}
