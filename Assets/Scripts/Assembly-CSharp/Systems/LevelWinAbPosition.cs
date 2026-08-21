using UnityEngine;

namespace Systems
{
	public class LevelWinAbPosition : MonoBehaviour
	{
		[SerializeField]
		private RectTransform ui;

		[SerializeField]
		private Vector3 oldUIPosition;

		[SerializeField]
		private Vector3 newUIPosition;

		private void OnEnable()
		{
		}
	}
}
