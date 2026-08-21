using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class GoalParticleController : MonoBehaviour
{
	[SerializeField]
	private List<GameObject> colors;

	private const int Samples = 24;

	private Tween _moveTween;

	public void Move(Vector3 worldStartPos, Vector3 end, Action onComplete, float speedPxPerSec = 6000f)
	{
	}

	private float ApproximateQuadraticBezierLength(Vector3 a, Vector3 b, Vector3 c, int samples = 24)
	{
		return 0f;
	}

	public void ResetForPool()
	{
	}

	public void StopAllTweenSafe()
	{
	}

	public void SetColor(int targetIndex)
	{
	}
}
