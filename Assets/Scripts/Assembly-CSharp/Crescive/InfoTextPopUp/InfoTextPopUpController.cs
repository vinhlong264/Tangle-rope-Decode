using Crescive.HelperTypes;
using Crescive.Text;
using UnityEngine;

namespace Crescive.InfoTextPopUp
{
	public class InfoTextPopUpController : MonoBehaviour
	{
		[SerializeField]
		private InfoTextPopUpEvents events;

		[SerializeField]
		private CanvasGroup textCanvasGroup;

		[SerializeField]
		private TextDataBinder textDataBinder;

		[SerializeField]
		private StringSettableVariableReference messageVar;

		[SerializeField]
		private RectTransform textPivot;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SetupArgTargets(InfoTextPopUpArgs args)
		{
		}

		private void PlayAnimation(float stayDuration)
		{
		}

		private void OnPushCallback(InfoTextPopUpArgs args)
		{
		}
	}
}
