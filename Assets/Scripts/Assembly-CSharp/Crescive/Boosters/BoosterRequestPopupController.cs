using Crescive.Navigation;
using Crescive.TransformUtils;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

namespace Crescive.Boosters
{
	public class BoosterRequestPopupController : MonoBehaviour
	{
		[SerializeField]
		private BoosterChannel boosterChannel;

		[Space]
		[SerializeField]
		private Navigatable navigatable;

		[SerializeField]
		[Space]
		private Image itemIconImage;

		[SerializeField]
		private StringReference nameImageKey;

		[SerializeField]
		private StringReference itemDescription;

		[SerializeField]
		private StringReference usePhrase;

		[Space]
		[SerializeField]
		private bool hasFocus;

		[SerializeField]
		private Transform focusPivot;

		[SerializeField]
		private TransformChannel focusTarget;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SyncDataToComponents()
		{
		}

		private void OnRequestedCallback(BoosterChannel _)
		{
		}

		private void OnStartedCallback(BoosterChannel _)
		{
		}

		private void OnCanceledCallback(BoosterChannel _)
		{
		}

		private void SubscribeToBoosterChannel()
		{
		}

		private void UnsubscribeFromBoosterChannel()
		{
		}

		public void OnShow()
		{
		}

		public void StartBooster()
		{
		}
	}
}
