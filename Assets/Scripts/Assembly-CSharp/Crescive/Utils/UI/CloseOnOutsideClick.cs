using UnityEngine;

namespace Crescive.Utils.UI
{
	public class CloseOnOutsideClick : MonoBehaviour
	{
		[SerializeField]
		[Tooltip("The GameObject to disable when clicking outside")]
		private GameObject panelToClose;

		[SerializeField]
		[Tooltip("The actual panel content to check clicks against")]
		private GameObject panelContent;

		private void Update()
		{
		}

		private bool IsPointerOverPanel()
		{
			return false;
		}

		private void OnValidate()
		{
		}
	}
}
