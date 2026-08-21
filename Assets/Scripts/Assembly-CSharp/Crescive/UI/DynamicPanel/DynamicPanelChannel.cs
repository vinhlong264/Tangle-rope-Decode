using UnityEngine;

namespace Crescive.UI.DynamicPanel
{
	[CreateAssetMenu(fileName = "Dynamic Panel Channel", menuName = "Crescive/UI/Dynamic Panel/Dynamic Panel Channel")]
	public class DynamicPanelChannel : ScriptableObject
	{
		[field: SerializeField]
		public GameObject Panel { get; private set; }

		public void SetData(GameObject panel)
		{
		}

		public void ResetData()
		{
		}
	}
}
