using System.Collections.Generic;
using Crescive.HelperTypes;
using UnityEngine;

namespace Crescive.TransformUtils
{
	public class SiblingsRearranger : MonoBehaviour
	{
		[SerializeField]
		private List<Sibling> newOrder;

		[SerializeField]
		private BoolVariableReference rearrangeOnEnable;

		private void OnEnable()
		{
		}

		public void Rearrange()
		{
		}
	}
}
