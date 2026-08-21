using UnityEngine;

namespace Crescive.TimeUtils
{
	[CreateAssetMenu(menuName = "GameData/Channel/TimeScaleSetter", fileName = "TimeScaleSetter")]
	public class TimeScaleSetter : ScriptableObject
	{
		[SerializeField]
		private float defaultTimeScale;

		[SerializeField]
		private float defaultFixedTimeStep;

		[SerializeField]
		private bool updateFixedDeltaTime;

		public float TimeScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public void ResetTimeScale()
		{
		}

		public void FreezeTimeScale(bool updateFixedDeltaTime)
		{
		}

		public void SetTimeScale(float timeScale, bool updateFixedDeltaTime = true)
		{
		}

		public void SetFixedTimeStep(float fixedTimeStep)
		{
		}

		public void SetTimeScale(float timeScale)
		{
		}
	}
}
