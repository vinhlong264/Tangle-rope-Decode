namespace Crescive.Shop
{
	public interface IShopItemViewController
	{
		string ItemId { get; }

		void Setup(string id);

		void ShowAmount(bool show);

		void SetAmount(int amount);
	}
}
