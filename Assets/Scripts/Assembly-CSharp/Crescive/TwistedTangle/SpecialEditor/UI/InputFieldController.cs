using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle.SpecialEditor.UI
{
	public class InputFieldController : MonoBehaviour
	{
		[SerializeField]
		private TMP_InputField inputField;

		[SerializeField]
		private TMP_InputField actualText;

		public UnityEvent<string> OnSubmit;

		public UnityEvent<int> OnSubmitInt;

		public UnityEvent<float> OnSubmitFloat;

		public string Value { get; private set; }

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void ChangeValue(string valueToPass)
		{
		}

		public void SubmitValue()
		{
		}

		public void SetInputFieldTextWithoutNotify(string newName)
		{
		}

		public void ActivateInputFieldAndMoveCursorToEnd()
		{
		}
	}
}
