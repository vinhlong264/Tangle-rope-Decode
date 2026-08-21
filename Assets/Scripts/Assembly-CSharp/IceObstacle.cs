using System.Collections.Generic;
using Crescive.CreatorMode;
using Crescive.TwistedTangle;
using Game.Scripts.Events;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class IceObstacle : LiveObstacleEntity
{
	[SerializeField]
	private PinsChannel pinsChannel;

	[SerializeField]
	private List<IceObstacleVariant> iceVariants;

	[SerializeField]
	protected TMP_Text hpText;

	public Image hpImage;

	private IceObstacleVariant _activeVariant;

	[SerializeField]
	private Sprite colorfulSprite;

	private static readonly List<ShapeDefinition> predefinedShapes;

	public int Hp { get; private set; }

	public int MaxHp { get; private set; }

	public override Material GetMaterial()
	{
		return null;
	}

	public override void Flip(float slotRotateDuration)
	{
	}

	public override void Initialize(LiveObstacleData liveObstacleData)
	{
	}

	private void SetTransform(LiveObstacleData data)
	{
	}

	private void ActivateVariant(LiveObstacleData data)
	{
	}

	private void LockPins()
	{
	}

	private void FillPositions()
	{
	}

	private static Vector2Int RotateOffset(Vector2Int offset, int degrees, Vector2Int pivot)
	{
		return default(Vector2Int);
	}

	private void SetHp(int hp)
	{
	}

	private void TakeDamage(int amount)
	{
	}

	protected virtual void UpdateHpUI()
	{
	}

	protected override void OnCreated()
	{
	}

	protected override void OnDestroySelf()
	{
	}

	private void OnRopeMerged(InGameEvents.RopeMergedEvent obj)
	{
	}

	protected virtual bool CheckDamageCondition(RopeEntity objRopeEntity)
	{
		return false;
	}

	private static List<Vector2Int> GenerateGrid(int width, int height)
	{
		return null;
	}
}
