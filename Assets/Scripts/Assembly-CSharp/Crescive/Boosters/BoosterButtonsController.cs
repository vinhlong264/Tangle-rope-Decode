using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Boosters
{
	public class BoosterButtonsController : MonoBehaviour
	{
		[SerializeField]
		private BoosterButtonsControllerChannel channel;

		[SerializeField]
		private BoosterSystem boosterSystem;

		[SerializeField]
		private List<BoosterButton> boosterButtons;

		public void Setup()
		{
		}

		public BoosterButton GetBoosterButton(BoosterChannel boosterChannel)
		{
			return null;
		}

		public void ResetTemporaryButtonStates()
		{
		}
	}
}
