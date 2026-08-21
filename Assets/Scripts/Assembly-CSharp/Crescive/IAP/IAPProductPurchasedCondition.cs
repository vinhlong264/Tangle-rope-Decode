using System.Collections.Generic;
using UnityAtoms;
using UnityEngine;

namespace Crescive.IAP
{
	[CreateAssetMenu(menuName = "Crescive/IAP/Conditions/IAP Product Purchased")]
	public class IAPProductPurchasedCondition : AtomCondition, IProductId
	{
		public string Id;

		[SerializeField]
		private IAPDataService service;

		private List<string> ProductIds => null;

		public string ProductId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override bool Call()
		{
			return false;
		}
	}
}
