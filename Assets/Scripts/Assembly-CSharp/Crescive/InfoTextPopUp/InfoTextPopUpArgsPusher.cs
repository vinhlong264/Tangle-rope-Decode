using System.Collections.Generic;
using Crescive.HelperTypes;
using UnityEngine;

namespace Crescive.InfoTextPopUp
{
	public class InfoTextPopUpArgsPusher : MonoBehaviour
	{
		[SerializeField]
		private InfoTextPopUpEvents events;

		[SerializeField]
		private InfoTextPopUpArgs args;

		[SerializeField]
		private List<BoolVariableReference> pushConditions;

		private bool CanPush => false;

		public void Push()
		{
		}
	}
}
