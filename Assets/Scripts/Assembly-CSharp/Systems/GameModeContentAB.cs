using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Systems
{
	public class GameModeContentAB : MonoBehaviour
	{
		[SerializeField]
		private GameObject moveTimeContent;

		[SerializeField]
		private GameObject RetryContent;

		[SerializeField]
		private GameObject BgContent;

		[SerializeField]
		private GameObject abContent;

		[SerializeField]
		private GameObject goalContent;

		[SerializeField]
		private GameObject stageContentA;

		[SerializeField]
		private GameObject stageContentB;

		[SerializeField]
		private RectTransform abTimeContentRect;

		[SerializeField]
		private RectTransform abTimeHeader;

		[SerializeField]
		private RectTransform timeMask;

		public Vector2 middleMaskSize;

		public Vector2 rightMaskSize;

		public Vector3 middlePosition;

		public Vector3 rightPosition;

		[SerializeField]
		private StringVariable levelType;

		public static bool IsNewThemeOn => false;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnLevelCreated(GameEvents.OnLevelCreated p)
		{
		}
	}
}
