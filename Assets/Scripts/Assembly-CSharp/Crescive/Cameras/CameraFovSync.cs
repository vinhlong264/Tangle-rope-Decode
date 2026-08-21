using UnityEngine;

namespace Crescive.Cameras
{
	[ExecuteAlways]
	public class CameraFovSync : MonoBehaviour
	{
		[SerializeField]
		private Camera selfCamera;

		[SerializeField]
		private Camera referenceCamera;

		private void Update()
		{
		}

		private void UpdateSelf()
		{
		}
	}
}
