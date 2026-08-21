using System;
using System.Collections.Generic;
using Crescive.DataService;

namespace Crescive.IAP
{
	[Serializable]
	public class BundlePack : ICloneable, IPackInfo, IMergeable<BundlePack>
	{
		public bool Enabled;

		public bool IsDiscount;

		public string Id;

		public string Name;

		public string Description;

		public List<Bundle> Bundles;

		public string id => null;

		public string description => null;

		public BundlePack()
		{
		}

		public BundlePack(BundlePack other)
		{
		}

		public object Clone()
		{
			return null;
		}

		public void Merge(BundlePack other)
		{
		}

		public bool CanMergeWith(BundlePack other)
		{
			return false;
		}
	}
}
