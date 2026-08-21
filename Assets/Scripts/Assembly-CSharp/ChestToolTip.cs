using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestToolTip : MonoBehaviour
{
	[SerializeField]
	private GameObject main;

	[SerializeField]
	private List<ItemDisplayer> itemDisplayers;

	[SerializeField]
	private Button closeButton;

	private void Awake()
	{
	}

	public void ShowTooltip(RewardList rewardList, Vector3 position)
	{
	}

	private void CloseTooltip()
	{
	}
}
