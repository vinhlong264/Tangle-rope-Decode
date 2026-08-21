using DG.Tweening;
using UnityEngine;

public class IceObstacleVariant : MonoBehaviour
{
	public ObstacleSubType shapeType;

	[SerializeField]
	private GameObject prefab;

	[SerializeField]
	private IceModelHp[] iceModelHp;

	[SerializeField]
	private Animator splitAnimator;

	[SerializeField]
	private Animator explosionAnimator;

	[SerializeField]
	private float modelChangeDelay;

	[SerializeField]
	[Header("Shake Settings")]
	private float shakeDuration;

	[SerializeField]
	private float shakeStrength;

	private IceModelHp _currentModel;

	private Tween _shakeTween;

	private static readonly int Explode;

	private static readonly int Death;

	public Collider collider;

	public Material Material => null;

	public void SetState(bool isActive)
	{
	}

	public void Init()
	{
	}

	public void SetModel(float hpRatio, bool playAnimationIfChanged = true)
	{
	}

	private void ApplyModel(IceModelHp newModel)
	{
	}

	private void CloseAllModels()
	{
	}

	public void PlayDeathAnimation()
	{
	}

	public void PlayDamageAnimation()
	{
	}

	private void Update()
	{
	}

	private void Shake()
	{
	}

	public void PrefabSetRotateZ(float zRotation, float slotRotateDuration)
	{
	}
}
