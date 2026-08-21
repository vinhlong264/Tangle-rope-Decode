using Cinemachine;
using UnityEngine;

namespace Crescive.Cameras
{
	[RequireComponent(typeof(CinemachineBrain))]
	[ExecuteInEditMode]
	public class HorizontalCinemachineCamera : MonoBehaviour
	{
		[SerializeField]
		private float m_fieldOfView;

		[SerializeField]
		private float m_orthographicSize;

		private CinemachineBrain brain;

		private float lastAspect;

		public float FieldOfView
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float OrthographicSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private void RefreshCamera()
		{
		}

		private void AdjustCamera(float aspect)
		{
		}

		private void OnEnable()
		{
		}

		private void Update()
		{
		}
	}
}
