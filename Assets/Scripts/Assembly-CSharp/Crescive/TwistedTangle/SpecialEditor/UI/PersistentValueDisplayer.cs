using PersistentSO;
using TMPro;
using UnityEngine;

namespace Crescive.TwistedTangle.SpecialEditor.UI
{
	public class PersistentValueDisplayer : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI text;

		[SerializeField]
		private BasePersistentVariable persistentVariable;

		[SerializeField]
		private string prefix;

		[SerializeField]
		private string suffix;

		private void SetText(object arg0)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
