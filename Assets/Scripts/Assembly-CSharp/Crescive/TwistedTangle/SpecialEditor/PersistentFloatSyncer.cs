using PersistentSO;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle.SpecialEditor
{
	public class PersistentFloatSyncer : MonoBehaviour
	{
		[SerializeField]
		private PersistentFloatVariable floatToSyncTo;

		[SerializeField]
		private UnityEvent<float> OnStart;

		[SerializeField]
		private UnityEvent<float> OnFloatIsChanged;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		public void FloatIsChanged(float value)
		{
		}
	}
}
