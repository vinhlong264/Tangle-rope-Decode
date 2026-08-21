using UnityEngine;
using UnityEngine.UI;

namespace Systems
{
	public class LevelWinABLayoutValue : MonoBehaviour
	{
		[SerializeField]
		private VerticalLayoutGroup verticalLayourGroup;

		[SerializeField]
		private RectOffset oldOffset;

		[SerializeField]
		private RectOffset newOffset;

		private void OnEnable()
		{
		}
	}
}
