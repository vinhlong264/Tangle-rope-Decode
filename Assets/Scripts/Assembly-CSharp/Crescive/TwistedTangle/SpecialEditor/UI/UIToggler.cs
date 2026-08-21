using PersistentSO;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Crescive.TwistedTangle.SpecialEditor.UI
{
	public class UIToggler : MonoBehaviour
	{
		[SerializeField]
		private PersistentBoolVariable persistentIsOn;

		[SerializeField]
		private Toggle toggle;

		[SerializeField]
		private UnityEvent<bool> OnToggleIsChanged;

		[SerializeField]
		private UnityEvent OnToggleIsOn;

		[SerializeField]
		private UnityEvent OnToggleIsOff;

		private void Awake()
		{
		}

		private void InitializeToggle()
		{
		}

		private void OnToggle()
		{
		}

		private void OffToggle()
		{
		}

		public void Toggle(bool isSActive)
		{
		}
	}
}
