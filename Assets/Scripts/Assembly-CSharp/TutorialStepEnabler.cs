using System.Collections.Generic;
using Crescive.TwistedTangle;
using DG.Tweening;
using UnityEngine;

public class TutorialStepEnabler : MonoBehaviour
{
	[Header("Prefabs & Refs")]
	[SerializeField]
	private GameObject mask;

	[SerializeField]
	private FakeCircleController circle;

	[SerializeField]
	private ColorSecondLevelTutorialPopup cp;

	[Header("Pin Seçimi")]
	[SerializeField]
	private int pinIndexFrom;

	[SerializeField]
	private int pinIndexTo;

	[Header("Anim Ayarları (DOTween)")]
	[SerializeField]
	private float goDuration;

	[SerializeField]
	private float backDuration;

	[SerializeField]
	private float startScale;

	[SerializeField]
	private float endScale;

	[SerializeField]
	private Ease goEase;

	[SerializeField]
	private Ease backEase;

	private GameObject _maskObj;

	private FakeCircleController _circleController;

	private RectTransform _handRT;

	private Sequence _handSeq;

	private RectTransform _canvasRT;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private static bool IsValid(IReadOnlyList<PinSlotEntity> list, int index)
	{
		return false;
	}

	private static Vector2 WorldToCanvasLocal(Vector3 worldPos, RectTransform canvasRT)
	{
		return default(Vector2);
	}
}
