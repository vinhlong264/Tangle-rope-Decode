using Crescive.TwistedTangle;
using UnityEngine;

namespace Crescive.Collection
{
	public class RopeModelMaterialSetter : BaseRopeModelActor
	{
		[SerializeField]
		private Material material;

		protected override void OnInitialized()
		{
		}

		protected override void OnColorUpdated(Color color)
		{
		}
	}
}
