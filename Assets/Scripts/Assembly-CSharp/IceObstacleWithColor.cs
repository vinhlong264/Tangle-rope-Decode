using Crescive.TwistedTangle;
using UnityEngine;

public class IceObstacleWithColor : IceObstacle
{
	[SerializeField]
	private Sprite whiteSprite;

	protected override bool CheckDamageCondition(RopeEntity objRopeEntity)
	{
		return false;
	}

	protected override void UpdateHpUI()
	{
	}

	private bool ColorsApproximatelyEqual(Color a, Color b, float tolerance = 0.01f)
	{
		return false;
	}
}
