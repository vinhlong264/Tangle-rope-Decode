using Crescive.DataService;
using Crescive.HelperTypes;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle.SingleLineProgression
{
	[CreateAssetMenu(fileName = "In Game Offer Data Service", menuName = "Crescive/In Game Offer/In Game Offer Data Service")]
	public class InGameOfferDataService : DataReadService<InGameOfferData>
	{
		[SerializeField]
		private IntVariable currentRepeatCount;

		[SerializeField]
		private IntVariableReference currentTryAgainCount;

		[SerializeField]
		private StringReference itemId;

		public UnityEvent<int> OnGrantItemAmountInt;

		public UnityEvent<float> OnGrantItemAmountFloat;

		public UnityEvent<InGameOfferItemGrantedArgs> OnItemGranted;

		public string ItemId => null;

		protected override InGameOfferData GetInitialDataCopy()
		{
			return null;
		}

		protected override bool IsDataValid(InGameOfferData plainData)
		{
			return false;
		}

		public float GetCurrentCost()
		{
			return 0f;
		}

		public int GetCurrentAmount()
		{
			return 0;
		}

		public int GetPreviousAmount()
		{
			return 0;
		}

		public void GrantItem(Transform grantTransform, bool increaseRepeatCount, InGameOfferGrantType? grantType)
		{
		}
	}
}
