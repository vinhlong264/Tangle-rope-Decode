using Obi;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	public class RopeCutter : MonoBehaviour
	{
		[SerializeField]
		private ObiRope rope;

		public UnityEvent OnRopeTearStarted;

		public UnityEvent OnRopeTear;

		public UnityEvent<Vector3> OnRopeTearPosition;

		public ObiStructuralElement TearFromPercent(float percent)
		{
			return null;
		}

		public void TearFromElement(ObiStructuralElement element)
		{
		}

		public Vector3 GetElementPosition(ObiStructuralElement element)
		{
			return default(Vector3);
		}

		public (Vector3, Vector3) GetElementParticlePositions(ObiStructuralElement element)
		{
			return default((Vector3, Vector3));
		}

		public int GetTearableElementIndex(int index)
		{
			return 0;
		}

		public int GetTearableElementIndexAtPercent(float percent)
		{
			return 0;
		}

		public ObiStructuralElement GetTearableElementAtPercent(float percent)
		{
			return null;
		}

		private void FixVisualAfterTear(float percent)
		{
		}
	}
}
