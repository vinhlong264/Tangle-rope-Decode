using UnityEngine;
using UnityEngine.UI;

namespace Crescive.Layout
{
	[DefaultExecutionOrder(-1)]
	public class LayoutViewContainerWidthHeightSetter : MonoBehaviour
	{
		[SerializeField]
		private RectTransform container;

		[SerializeField]
		private LayoutElement layoutElement;

		private float lastScreenWidth;

		private float lastScreenHeight;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void SyncLayoutElementToScreen()
		{
		}
	}
}
