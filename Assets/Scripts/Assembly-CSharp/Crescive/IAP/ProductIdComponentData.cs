using System.Collections.Generic;
using UnityEngine;

namespace Crescive.IAP
{
	[DisallowMultipleComponent]
	public class ProductIdComponentData : MonoBehaviour, IProductId
	{
		[SerializeField]
		protected string productId;

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

		private List<string> ProductIds => null;

		public void SetAllChildrenProductIds(bool includeInactive = true)
		{
		}
	}
}
