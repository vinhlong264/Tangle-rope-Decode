using System;
using PersistentSO;
using UnityEngine;

namespace Crescive.TwistedTangle.SpecialEditor.UI
{
	[CreateAssetMenu(fileName = "CamProperties", menuName = "Special Editor/Cam Properties")]
	public class CamPropertiesChannel : ScriptableObject
	{
		[SerializeField]
		private PersistentFloatVariable camXPersistent;

		[SerializeField]
		private PersistentFloatVariable camYPersistent;

		[SerializeField]
		private PersistentFloatVariable camZPersistent;

		[SerializeField]
		private PersistentFloatVariable camFOVPersistent;

		public float CamXPersistentValue => 0f;

		public float CamYPersistentValue => 0f;

		public float CamZPersistentValue => 0f;

		public float CamFOVPersistentValue => 0f;

		public float CameraX { get; private set; }

		public float CameraY { get; private set; }

		public float CameraZ { get; private set; }

		public float CameraFOV { get; private set; }

		public float InitialCameraX { get; private set; }

		public float InitialCameraY { get; private set; }

		public float InitialCameraZ { get; private set; }

		public float InitialCameraFOV { get; private set; }

		public Action<float> OnCameraXChanged { get; set; }

		public Action<float> OnCameraYChanged { get; set; }

		public Action<float> OnCameraZChanged { get; set; }

		public Action<float> OnCameraFOVChanged { get; set; }

		public Action OnResetCamX { get; set; }

		public Action OnResetCamY { get; set; }

		public Action OnResetCamZ { get; set; }

		public Action OnResetCamFOV { get; set; }

		public Action OnResetEverything { get; set; }

		public void SetCamXValue(float newValue)
		{
		}

		public void SetCamYValue(float newValue)
		{
		}

		public void SetCamZValue(float newValue)
		{
		}

		public void SetCamFOVValue(float newValue)
		{
		}

		public void SetInitialCamXValue(float newValue)
		{
		}

		public void SetInitialCamYValue(float newValue)
		{
		}

		public void SetInitialCamZValue(float newValue)
		{
		}

		public void SetInitialCamFOVValue(float newValue)
		{
		}

		public void ResetEverything()
		{
		}

		public void ResetCamX()
		{
		}

		public void ResetCamY()
		{
		}

		public void ResetCamZ()
		{
		}

		public void ResetCamFOV()
		{
		}

		public void LoadEverything()
		{
		}
	}
}
