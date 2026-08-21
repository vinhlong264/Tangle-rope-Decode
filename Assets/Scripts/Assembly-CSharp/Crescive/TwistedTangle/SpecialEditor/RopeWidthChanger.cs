using PersistentSO;
using UnityEngine;

namespace Crescive.TwistedTangle.SpecialEditor
{
	[DefaultExecutionOrder(1)]
	public class RopeWidthChanger : MonoBehaviour
	{
		[SerializeField]
		private RopesChannel ropesChannel;

		[SerializeField]
		private PersistentFloatVariable ropeWidthMultiplier;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SetRopesWidthScale(float newValue)
		{
		}

		private void SetRopeWidthScale(float scale, RopeEntity rope)
		{
		}

		private void OnRopeAdded(RopeEntity ropeEntity)
		{
		}
	}
}
