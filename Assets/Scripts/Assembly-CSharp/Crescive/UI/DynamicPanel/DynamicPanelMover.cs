using UnityEngine;
using UnityEngine.Events;

namespace Crescive.UI.DynamicPanel
{
	[DefaultExecutionOrder(-10000)]
	public class DynamicPanelMover : MonoBehaviour
	{
		[SerializeField]
		private DynamicPanelChannel dynamicPanelChannel;

		[SerializeField]
		private Transform panelParent;

		[Space]
		[SerializeField]
		private bool moveHereOnEnable;

		public UnityEvent<GameObject> OnMovedPanelHere;

		private void OnEnable()
		{
		}

		public void MoveHere()
		{
		}
	}
}
