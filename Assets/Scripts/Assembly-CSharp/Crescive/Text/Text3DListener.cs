using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Text
{
	public class Text3DListener : MonoBehaviour
	{
		[Header("References")]
		[SerializeField]
		private Text3DBehaviour text3DBehaviour;

		[Header("Events")]
		[SerializeField]
		private UnityEvent OnTextUpdated;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnTextUpdatedCallback()
		{
		}
	}
}
