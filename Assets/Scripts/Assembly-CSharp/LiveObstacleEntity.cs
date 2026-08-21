using System.Collections.Generic;
using Crescive.CreatorMode;
using Crescive.Draggables;
using Crescive.TwistedTangle;
using UnityEngine;

public abstract class LiveObstacleEntity : MonoBehaviour
{
	public ObstacleType obstacleType;

	public Transform graphicsParent;

	public List<PinEntity> LockedPins;

	public Collider Collider;

	protected bool IsFlipped;

	public LiveObstacleData ObstacleData { get; private set; }

	private void Update()
	{
	}

	public virtual void Flip(float slotRotateDuration)
	{
	}

	private float NormalizeAngle(float angle)
	{
		return 0f;
	}

	public virtual void Initialize(LiveObstacleData liveObstacleData)
	{
	}

	public void DestroySelf()
	{
	}

	protected virtual void OnCreated()
	{
	}

	protected virtual void OnDestroySelf()
	{
	}

	private void ResetSelf()
	{
	}

	public bool IsCollidingWithDraggable(Draggable draggable)
	{
		return false;
	}

	public bool IsCollidingWithDraggable(PinEntity pinEntity)
	{
		return false;
	}

	private bool AreCollidersTouchingWithPin(Collider pinCol)
	{
		return false;
	}

	public void ChangeData(LiveObstacleData liveObstacleData)
	{
	}

	public virtual Material GetMaterial()
	{
		return null;
	}
}
