using UnityEngine;
using UnityEngine.UI;

namespace Crescive.UI
{
	[DefaultExecutionOrder(-1)]
	public class NestedScrollRectController : MonoBehaviour
	{
		[SerializeField]
		private NestedScrollRect nestedScrollRect;

		[SerializeField]
		private bool autoFindParentScrollRect;

		[SerializeField]
		private ScrollRect parentScrollRect;

		private void Awake()
		{
		}
	}
}
