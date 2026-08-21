using DG.Tweening;
using UnityEngine;

public class UIPingPongMotion : MonoBehaviour
{
	[Header("Movement Settings")]
	[SerializeField]
	private Vector3 startPosition;

	[SerializeField]
	private Vector3 endPosition;

	[SerializeField]
	private float duration;

	[SerializeField]
	private Ease easeType;

	[SerializeField]
	[Header("Advanced Options")]
	private bool useLocalPosition;

	[SerializeField]
	private bool startFromCurrentPosition;

	[SerializeField]
	private bool useRectTransform;

	private RectTransform rectTransform;

	private Tweener motionTween;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void StartContinuousMotion()
	{
	}

	private void ResetToStartPosition()
	{
	}

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	private void ResetAnimation()
	{
	}
}
