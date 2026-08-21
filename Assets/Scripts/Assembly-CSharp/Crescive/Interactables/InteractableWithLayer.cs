using UnityEngine;

namespace Crescive.Interactables
{
	public class InteractableWithLayer : BaseInteractable
	{
		[SerializeField]
		private LayerMask layer;

		protected override bool ValidateActor(GameObject g)
		{
			return false;
		}
	}
}
