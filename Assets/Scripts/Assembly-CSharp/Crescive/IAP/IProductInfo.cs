using System;

namespace Crescive.IAP
{
	public interface IProductInfo : ICloneable
	{
		bool enabled { get; }

		bool useInShop { get; }

		string name { get; }

		string id { get; }

		string description { get; }

		bool isConsumable { get; }

		int amount { get; set; }

		string adjustEventToken { get; }

		string elephantEventParam { get; }

		float price { get; }
	}
}
