using System.Collections.Generic;
using UnityEngine;

namespace Crescive.PowerUps
{
	public class PowerUpButtonsController : MonoBehaviour
	{
		[SerializeField]
		private PowerUpButtonsControllerChannel channel;

		[SerializeField]
		private PowerUpSystem powerUpSystem;

		[SerializeField]
		private List<PowerUpButton> powerUpButtons;

		[SerializeField]
		[Space]
		private bool autoSetupOnEnable;

		private void OnEnable()
		{
		}

		public void Setup()
		{
		}

		public PowerUpButton GetPowerUpButton(PowerUpChannel powerUpChannel)
		{
			return null;
		}

		public void ResetTemporaryButtonStates()
		{
		}
	}
}
