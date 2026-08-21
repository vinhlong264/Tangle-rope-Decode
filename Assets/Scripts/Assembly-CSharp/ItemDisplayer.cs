using System;
using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemDisplayer : MonoBehaviour
{
	[SerializeField]
	private Image itemIcon;

	[SerializeField]
	internal SkeletonGraphic spine;

	[SerializeField]
	private TextMeshProUGUI countText;

	[SerializeField]
	private GameObject shine;

	[SerializeField]
	private Button itemButton;

	public void DisplayItem(ItemType itemType, Sprite icon, int count, bool isShineOn = true, Action onClick = null)
	{
	}

	public void DisplayItem(ItemType itemType, SkeletonDataAsset skeletonDataAsset, int count, bool isShineOn = true, Action onClick = null)
	{
	}

	private void DisplayItem(ItemType itemType, int count, bool isShineOn, Action onClick)
	{
	}

	public void DisplayItem(ItemData itemData, bool isShineOn = true, Action onClick = null)
	{
	}
}
