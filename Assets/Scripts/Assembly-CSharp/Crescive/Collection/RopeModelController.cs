using Crescive.TwistedTangle;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Collection
{
	public class RopeModelController : MonoBehaviour
	{
		[SerializeField]
		private RopeEntity rope;

		[SerializeField]
		private RopeRendererType ropeRendererType;

		public UnityEvent OnInitialized;

		public RopeEntity Rope => null;

		public void Initialize(RopeEntity ropeEntity)
		{
		}
	}
}
