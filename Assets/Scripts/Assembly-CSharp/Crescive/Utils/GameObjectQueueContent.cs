using System.Collections.Generic;
using Crescive.HelperTypes;
using UnityEngine;

namespace Crescive.Utils
{
	public class GameObjectQueueContent : MonoBehaviour
	{
		[SerializeField]
		private List<BoolVariableReference> canBeQueuedConditions;

		[SerializeField]
		private GameObject enablePivot;

		private GameObject EnablePivot => null;

		public bool CanBeQueued()
		{
			return false;
		}

		public void SetActive(bool value)
		{
		}
	}
}
