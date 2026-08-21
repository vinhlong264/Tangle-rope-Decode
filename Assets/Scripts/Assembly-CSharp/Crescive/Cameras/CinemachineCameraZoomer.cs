using Cinemachine;
using DG.Tweening;
using UnityEngine;

namespace Crescive.Cameras
{
	public class CinemachineCameraZoomer : MonoBehaviour
	{
		[SerializeField]
		private CinemachineVirtualCamera cmCam;

		[SerializeField]
		private CameraZoomOutRatioVariable zoomRatio;

		[SerializeField]
		private float updateFovSpeed;

		[SerializeField]
		private float maxFovAmount;

		[SerializeField]
		private float maxOffsetDistance;

		[SerializeField]
		private float updateOffsetSpeed;

		[SerializeField]
		private UpdateType updateType;

		[SerializeField]
		private bool shouldUpdateFOV;

		private Tween updateFovTween;

		private Tween _updateFovTween;

		private float _defaultFov;

		private Vector3 _defaultOffset;

		private CinemachineTransposer _transposer;

		private void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		private void FixedUpdate()
		{
		}

		private void UpdateZoom()
		{
		}

		private void UpdateFov(float amount)
		{
		}

		private void UpdateOffset(float amount)
		{
		}
	}
}
