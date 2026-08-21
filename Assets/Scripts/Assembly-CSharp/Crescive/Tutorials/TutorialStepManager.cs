using System;
using UnityEngine;

namespace Crescive.Tutorials
{
	[Serializable]
	public abstract class TutorialStepManager : MonoBehaviour
	{
		public int Order;

		public abstract ITutorialState? CheckState();

		public abstract bool ShouldActivate(ITutorialState? currentState);

		public abstract void OnEnter(ITutorialState? currentState);

		public abstract void WhileActive(ITutorialState? currentState);

		public abstract void OnExit(ITutorialState? currentState);
	}
}
