using Crescive.IAP;
using DG.Tweening;
using UnityEngine;

public class IAPPurchaserSourceChanger : MonoBehaviour
{
	[SerializeField]
	private float delay;

	[SerializeField]
	private IAPSource inGameSource;

	[SerializeField]
	private IAPSource menuSource;

	private Tween tween;

	private void OnEnable()
	{
	}

	private void ChangeSources()
	{
	}
}
