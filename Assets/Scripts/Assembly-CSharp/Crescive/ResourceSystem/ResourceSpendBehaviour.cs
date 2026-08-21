using System.Collections.Generic;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.ResourceSystem
{
	public class ResourceSpendBehaviour : MonoBehaviour
	{
		[SerializeField]
		private ResourceChannel resourceChannel;

		[SerializeField]
		private Transform spendTransform;

		[SerializeField]
		private FloatReference spendAmount;

		[SerializeField]
		private List<AtomCondition> canSpendConditions;

		[SerializeField]
		private string info;

		private bool? canSpend;

		public UnityEvent OnSpendSuccessful;

		public UnityEvent OnSpendFailed;

		public UnityEvent OnCanSpend;

		public UnityEvent<bool> OnCanSpendChanged;

		public UnityEvent OnCanNotSpend;

		public UnityEvent<bool> OnCanNotSpendChanged;

		private string Info => null;

		public float SpendAmount => 0f;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void SubscribeToChannel()
		{
		}

		private void UnsubscribeFromChannel()
		{
		}

		private void OnResourceValueChangedCallback(float value)
		{
		}

		public void TrySpendInternal(ResourceValueEventArgs args)
		{
		}

		public void SetSpendAmount(float amount)
		{
		}

		public void TrySpend()
		{
		}

		public void TrySpendWorldPosition(Vector3 position)
		{
		}

		public void TrySpendCanvasPosition(Vector3 position, string info)
		{
		}

		public void TrySpendWorldPosition()
		{
		}

		public void TrySpendCanvasPosition(string info)
		{
		}

		public void CheckCanSpend(bool force = false)
		{
		}

		public void SetResourceChannel(ResourceChannel channel)
		{
		}

		public void SetSpendInfo(StringConstant value)
		{
		}
	}
}
