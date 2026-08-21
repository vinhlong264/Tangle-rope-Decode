using System.Collections.Generic;
using MyBox;
using UnityEngine;

namespace Crescive.Interactables
{
	public class InteractableWithTag : BaseInteractable
	{
		[SerializeField]
		[Tag]
		private List<string> tags;

		protected override bool ValidateActor(GameObject g)
		{
			return false;
		}
	}
}
