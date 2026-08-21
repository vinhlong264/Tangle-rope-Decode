using DG.Tweening;
using UnityEngine;

public abstract class ObjectTransferer : ScriptableObject
{
	public abstract Sequence Transfer(Transform target, Transform destination, TweenCallback transferredCallback = null);

	public Sequence Transfer(Component target, Component destination, TweenCallback transferredCallback = null)
	{
		return null;
	}

	public Sequence Transfer(GameObject target, GameObject destination, TweenCallback transferredCallback = null)
	{
		return null;
	}
}
