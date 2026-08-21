using System;
using UnityEngine;

namespace Crescive.TwistedTangle.SingleLineProgression
{
	[Serializable]
	public class InGameOfferItemGrantedArgs
	{
		public InGameOfferDataService DataService;

		public Transform GrantTransform;

		public int ItemAmount;

		public int RepeatCount;

		public float Cost;

		public InGameOfferGrantType? GrantType;

		public InGameOfferItemGrantedArgs(InGameOfferDataService dataService, Transform grantTransform, int itemAmount, int repeatCount, float cost, InGameOfferGrantType? grantType)
		{
		}
	}
}
