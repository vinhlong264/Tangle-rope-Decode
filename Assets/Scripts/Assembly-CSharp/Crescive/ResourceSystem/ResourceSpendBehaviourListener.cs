using UnityEngine;
using UnityEngine.Events;

namespace Crescive.ResourceSystem
{
	[DefaultExecutionOrder(-100)]
	public class ResourceSpendBehaviourListener : MonoBehaviour
	{
		[SerializeField]
		private ResourceSpendBehaviour resourceSpendBehaviour;

		[SerializeField]
		private UnityEvent OnSpendSuccessful;

		[SerializeField]
		private UnityEvent OnSpendFailed;

		[SerializeField]
		private UnityEvent OnCanSpend;

		[SerializeField]
		private UnityEvent OnCanNotSpend;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnSpendSuccessfulCallback()
		{
		}

		private void OnSpendFailedCallback()
		{
		}

		private void OnCanSpendCallback()
		{
		}

		private void OnCanNotSpendCallback()
		{
		}
	}
}
