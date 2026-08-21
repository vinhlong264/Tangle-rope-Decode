using UnityEngine;

namespace Crescive.UI
{
	[CreateAssetMenu(fileName = "AnimatedRaycastTargetSettingsData", menuName = "Crescive/UI/AnimatedRaycastTargetSettingsData")]
	public class AnimatedRaycastTargetSettingsData : ScriptableObject
	{
		[SerializeField]
		private FloatAnimationSettings downSettings;

		[SerializeField]
		private FloatAnimationSettings enterSettings;

		[SerializeField]
		private FloatAnimationSettings exitSettings;

		[SerializeField]
		private FloatAnimationSettings clickPunchSettings;

		public FloatAnimationSettings DownSettings => null;

		public FloatAnimationSettings EnterSettings => null;

		public FloatAnimationSettings ExitSettings => null;

		public FloatAnimationSettings ClickPunchSettings => null;
	}
}
