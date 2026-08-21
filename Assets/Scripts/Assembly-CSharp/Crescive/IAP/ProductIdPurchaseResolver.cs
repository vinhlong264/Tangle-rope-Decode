using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.IAP
{
	public class ProductIdPurchaseResolver : BaseItemPurchaseResolver
	{
		[SerializeField]
		private IAPDataService dataService;

		[SerializeField]
		private string id;

		[Header("Resolve Events")]
		public UnityEvent OnResolved;

		public UnityEvent OnResolvedAsBundle;

		public UnityEvent OnResolvedAsProduct;

		[Header("Resolve Purchase State Active Events")]
		public UnityEvent OnResolvedPurchaseStateActive;

		[Header("Resolve Unclaim Events")]
		public UnityEvent OnResolvedUnclaim;

		public string Id => null;

		private List<string> Ids => null;

		protected override void ResolveBundle(BundlePurchaseResolverData data)
		{
		}

		protected override void ResolveProduct(ProductPurchaseResolveData data)
		{
		}

		protected override void ResolvePurchaseStateActiveProduct(ProductPurchaseResolveData data)
		{
		}

		protected override void ResolveProductUnclaim(ProductPurchaseResolveData data)
		{
		}
	}
}
