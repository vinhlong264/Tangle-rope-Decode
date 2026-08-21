using System;
using System.Collections.Generic;
using UnityEngine;

namespace Crescive.CreatorMode
{
	[Serializable]
	public class LiveObstacleData : ICloneable
	{
		public ObstacleType ObstacleType;

		public List<Vector3> Positions;

		public Vector3 Rotation;

		public ObstacleSubType obstacleSubType;

		public int Hp;

		public Color ObstacleColor;

		public LiveObstacleData(ObstacleType type, List<Vector3> positions, int hp, Color color, ObstacleSubType subType = ObstacleSubType.None, Vector3 rotation = default(Vector3))
		{
		}

		public LiveObstacleData(LiveObstacleData copy)
		{
		}

		public object Clone()
		{
			return null;
		}
	}
}
