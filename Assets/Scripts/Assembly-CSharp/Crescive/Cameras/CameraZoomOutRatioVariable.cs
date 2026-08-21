using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.Cameras
{
	[CreateAssetMenu(fileName = "CameraZoomOutRatioVariable.asset", menuName = "GameData/Camera/CameraZoomOutRatioVariable")]
	public class CameraZoomOutRatioVariable : ScriptableObject
	{
		public FloatReference max;

		public FloatReference min;

		public FloatReference current;

		public float Value => 0f;

		public void SetCurrent(float value)
		{
		}

		public void SetCurrent(int value)
		{
		}
	}
}
