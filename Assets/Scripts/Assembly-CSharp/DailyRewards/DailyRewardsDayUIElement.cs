using System;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

namespace DailyRewards
{
	public class DailyRewardsDayUIElement : MonoBehaviour
	{
		public ItemDisplayer ItemDisplayer;

		public GameObject Tick;

		public GameObject Filter;

		public Image TargetBG;

		public Sprite ReachedSprite;

		public Sprite NotReachedSprite;

		public Sprite ClaimedSprite;

		public Sprite OverrideIcon;

		private Action onClick;

		private Action onShowTooltip;

		private bool isClaimed;

		private bool isReached;

		private bool setCount;

		public void SetData(ItemType itemType, bool isClaimed, bool isReached, Sprite itemIcon, int itemCount, Sprite overideIcon = null, Action onClick = null, Action onShowTooltip = null, bool setCount = false)
		{
		}

		public void SetData(ItemType itemType, bool isClaimed, bool isReached, SkeletonDataAsset skeletonAssetData, int itemCount, Sprite overideIcon = null, Action onClick = null, Action onShowTooltip = null, bool setCount = false)
		{
		}

		private void SetData(bool isClaimed, bool isReached, Sprite overideIcon, Action onClick, Action onShowTooltip, bool setCount)
		{
		}

		private void OnDayClaimed()
		{
		}
	}
}
