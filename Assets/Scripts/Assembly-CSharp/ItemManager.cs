using Crescive.IAP;
using Crescive.ResourceSystem;
using Spine.Unity;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
	public static ItemManager Instance;

	[SerializeField]
	private ResourceChannel[] resourcesChannel;

	[SerializeField]
	private Sprite[] icons;

	[SerializeField]
	private SkeletonDataAsset[] spines;

	[SerializeField]
	private string[] descriptions;

	[SerializeField]
	private PersistentTemporaryProducts persistentTemporaryProducts;

	[SerializeField]
	private Sprite[] GoldIcons;

	[SerializeField]
	private SkeletonDataAsset[] goldSpines;

	private void Awake()
	{
	}

	public string GetDescription(ItemType itemType)
	{
		return null;
	}

	public string GetDescription(int itemType)
	{
		return null;
	}

	public Sprite GetItemIcon(int itemTypeIndex)
	{
		return null;
	}

	public SkeletonDataAsset GetItemSkeletonDataAsset(int itemTypeIndex)
	{
		return null;
	}

	public Sprite GetItemIcon(ItemType itemType)
	{
		return null;
	}

	public void GiveReward(ItemType itemType, int count, Vector3 position, string info)
	{
	}

	public void GiveReward(int itemType, int count, Vector3 position, string info)
	{
	}

	public Sprite GetCustomCoinIcon(int amount)
	{
		return null;
	}

	public SkeletonDataAsset GetCustomCoinSkeletonDataAsset(int amount)
	{
		return null;
	}

	public int GetCustomCoinIconIndex(int amount)
	{
		return 0;
	}

	public string GetCountString(int count)
	{
		return null;
	}

	private void TryGiveInfHearth(int min)
	{
	}
}
