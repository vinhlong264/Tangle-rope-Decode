using Crescive.Collection;
using Obi;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	[DefaultExecutionOrder(-100)]
	public class BaseRopeModelActor : MonoBehaviour
	{
		[SerializeField]
		protected RopeModelController ropeModelController;

		private bool isInitialized;

		protected RopeEntity Rope => null;

		protected RopeColorizer Colorizer => null;

		protected ObiRopeChainRenderer ChainRenderer => null;

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void TriggerEvents()
		{
		}

		private void SubscribeToRopeEvents()
		{
		}

		private void UnsubscribeFromRopeEvents()
		{
		}

		private void OnInitializedCallback()
		{
		}

		protected virtual void OnInitialized()
		{
		}

		protected virtual void OnColorUpdated(Color color)
		{
		}

		protected virtual void OnColorUpdatedTemporary(Color color)
		{
		}

		protected virtual void OnSubColorUpdated(Color color, int nameId)
		{
		}
	}
}
