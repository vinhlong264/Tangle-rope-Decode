using System;
using System.Runtime.InteropServices;
using Spine.Unity;
using UnityEngine;

public class GameEvents
{
	[StructLayout((LayoutKind)0, Size = 1)]
	public struct OnReturnedHome : IEvent
	{
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	public struct PauseTimer : IEvent
	{
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	public struct OnGameWin : IEvent
	{
	}

	public struct OnRopesMerged : IEvent
	{
		public int colorIndex1;

		public int colorIndex2;

		public Vector3 centerPos;

		public OnRopesMerged(int colorIndex1, int colorIndex2, Vector3 centerPos)
		{
			this.colorIndex1 = 0;
			this.colorIndex2 = 0;
			this.centerPos = default(Vector3);
		}
	}

	public struct OnRopesMergeStarted : IEvent
	{
		public int colorIndex1;

		public int colorIndex2;

		public OnRopesMergeStarted(int colorIndex1, int colorIndex2)
		{
			this.colorIndex1 = 0;
			this.colorIndex2 = 0;
		}
	}

	public struct OnRopeDrop : IEvent
	{
		public bool isDropTargetExist;

		public OnRopeDrop(bool isDropTargetExist)
		{
			this.isDropTargetExist = false;
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	public struct OnRopeSelect : IEvent
	{
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	public struct OnLevelCreated : IEvent
	{
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	public struct OnRopeMergeThatNotTarget : IEvent
	{
	}

	public struct OnChestRewardAnimation : IEvent
	{
		public SkeletonDataAsset skeletonDataAsset;

		public RewardList rewardList;

		public Action onComplete;

		public string header;

		public OnChestRewardAnimation(SkeletonDataAsset skeletonDataAsset, RewardList rewardList, string header, Action onComplete)
		{
			this.skeletonDataAsset = null;
			this.rewardList = null;
			this.onComplete = null;
			this.header = null;
		}
	}

	public struct OnLevelNumberChanged : IEvent
	{
		public int levelNumber;

		public OnLevelNumberChanged(int levelNumber)
		{
			this.levelNumber = 0;
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	public struct OnHomeMenuEnabled : IEvent
	{
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	public struct OnHomeMenuDisabled : IEvent
	{
	}
}
