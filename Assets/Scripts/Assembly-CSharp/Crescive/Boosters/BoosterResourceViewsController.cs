using System.Collections.Generic;
using Crescive.ResourceSystem.UI;
using UnityEngine;

namespace Crescive.Boosters
{
	public class BoosterResourceViewsController : MonoBehaviour
	{
		[SerializeField]
		private BoosterSystem boosterSystem;

		[SerializeField]
		private Transform resourceModelParent;

		[SerializeField]
		private List<ResourceAnimationTarget> resourceAnimationTargets;

		[Space]
		[SerializeField]
		private bool autoSetupOnEnable;

		private void OnEnable()
		{
		}

		public void Setup()
		{
		}
	}
}
