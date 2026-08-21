using System.Collections.Generic;
using UnityEngine;

public class ShapeDefinition
{
	public ObstacleSubType Shape { get; }

	public List<Vector2Int> Offsets { get; }

	public ShapeDefinition(ObstacleSubType shape, List<Vector2Int> offsets)
	{
	}
}
