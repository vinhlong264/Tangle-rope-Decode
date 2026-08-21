using System.Collections.Generic;
using Crescive.CreatorMode;
using Crescive.TwistedTangle;
using MyBox;
using UnityEngine;

public class LiveObstacleChannel : Singleton<LiveObstacleChannel>
{
	[SerializeField]
	private List<LiveObstacleEntity> liveObstaclePrefab;

	public List<LiveObstacleEntity> objects;

	public List<LiveObstacleData> GetLiveObstacleData()
	{
		return null;
	}

	public void CreatLiveObstacles(List<LiveObstacleData> stageDataLiveObstaclesData)
	{
	}

	public LiveObstacleEntity ChangeObstacleType(LiveObstacleEntity liveObstacleEntity, ObstacleType newType)
	{
		return null;
	}

	public void CreateLiveObstacle(LiveObstacleData liveObstacleData)
	{
	}

	public LiveObstacleEntity CreateDummyObstacle()
	{
		return null;
	}

	public void RemoveAt(int index)
	{
	}

	private void ClearObstacles()
	{
	}

	public List<LiveObstacleEntity> GetFilteredObstacle(ObstacleType obstacleType)
	{
		return null;
	}

	public void RemoveObstacle(LiveObstacleEntity obstacle)
	{
	}

	public void AddObstacle(LiveObstacleEntity obstacle)
	{
	}

	public void Remove(LiveObstacleEntity index)
	{
	}

	public bool CanCutBoostPerform(RopeEntity dataRope)
	{
		return false;
	}

	public PinEntity GetRandomPinExceptLockedPins(IReadOnlyList<PinEntity> pinsChannelObjects)
	{
		return null;
	}
}
