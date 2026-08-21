using System.Collections.Generic;
using UnityAtoms;
using UnityEngine;

namespace Crescive.IAP
{
	[CreateAssetMenu(menuName = "Crescive/IAP/Conditions/IAP Product Available")]
	public class IAPProductAvailableCondition : AtomCondition, IProductId
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
