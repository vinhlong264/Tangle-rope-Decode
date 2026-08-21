using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle.SingleLineProgression
{
	public class InGameOfferController : MonoBehaviour
	{
		[SerializeField]
		private InGameOfferDataService dataService;

		[SerializeField]
		private FloatReference currentCost;

		[SerializeField]
		private IntReference itemAmount;

		[SerializeField]
		private IntReference bonusAmount;

		[SerializeField]
		private Transform grantTransform;

		[SerializeField]
		private bool firstTimeFreePopup;

		[SerializeField]
		private string firstTimeFreeId;

		[Header("Settings")]
		[SerializeField]
		private bool increaseRepeatCountOnApproved;

		public UnityEvent<int> OnGrantItemAmountInt;

		public UnityEvent<float> OnGrantItemAmountFloat;

		public UnityEvent OnItemGranted;

		public UnityEvent<int, Transform> OnItemGrantedIntTransform;

		public InGameOfferDataService DataService => null;

		public FloatReference CurrentCost => null;

		public IntReference ItemAmount => null;

		public Transform GrantTransform => null;

		private bool IsGetFirstTimeFree
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		public void OnApproved()
		{
		}

		public void OnApprovedCoin()
		{
		}

		public void OnApprovedIAP()
		{
		}

		public void OnApprovedRW()
		{
		}

		private void OnApprovedInternal(InGameOfferGrantType? grantType)
		{
		}
	}
}
