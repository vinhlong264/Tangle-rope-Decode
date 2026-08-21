using PersistentSO;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle.SpecialEditor
{
	public class PersistentBoolSyncer : MonoBehaviour
	{
		[SerializeField]
		private PersistentBoolVariable boolToSyncTo;

		[SerializeField]
		private UnityEvent<bool> OnBoolIsChanged;

		[SerializeField]
		private UnityEvent OnBoolIsTrue;

		[SerializeField]
		private UnityEvent OnBoolIsFalse;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void BoolIsChanged(bool isTrue)
		{
		}
	}
}
