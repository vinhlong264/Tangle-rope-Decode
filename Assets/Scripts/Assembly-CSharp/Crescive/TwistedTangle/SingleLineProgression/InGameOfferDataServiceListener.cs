using System.Collections.Generic;
using UnityAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle.SingleLineProgression
{
	public class InGameOfferDataServiceListener : MonoBehaviour
	{
		[SerializeField]
		private InGameOfferDataService dataService;

		[SerializeField]
		private List<AtomCondition> conditions;

		public UnityEvent<int> OnGrantItemAmountInt;

		public UnityEvent<float> OnGrantItemAmountFloat;

		public UnityEvent<InGameOfferItemGrantedArgs> OnItemGranted;

		public UnityEvent<int, Transform> OnItemGrantedIntTransform;

		public UnityEvent<float, Transform> OnItemGrantedFloatTransform;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnGrantItemAmountIntCallback(int amount)
		{
		}

		private void OnGrantItemAmountFloatCallback(float amount)
		{
		}

		private void OnItemGrantedCallback(InGameOfferItemGrantedArgs args)
		{
		}
	}
}
