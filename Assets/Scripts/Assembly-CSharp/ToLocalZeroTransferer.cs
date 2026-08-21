using BrunoMikoski.AnimationSequencer;
using DG.Tweening;
using UnityEngine;

[CreateAssetMenu(fileName = "To Local Zero Transferer", menuName = "ScriptableObjects/Object Transferer/To Local Zero Transferer")]
public class ToLocalZeroTransferer : ObjectTransferer
{
	[Header("Settings")]
	[SerializeField]
	protected float duration;

	[SerializeField]
	protected CustomEase customEase;

	[SerializeField]
	protected bool useStaticSpeed;

	[SerializeField]
	protected float speed;

	public override Sequence Transfer(Transform target, Transform destination, TweenCallback transferredCallback = null)
	{
		return null;
	}
}
