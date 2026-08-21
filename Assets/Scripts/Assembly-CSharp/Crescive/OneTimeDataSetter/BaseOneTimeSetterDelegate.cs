using System.Collections.Generic;
using Crescive.HelperTypes;
using PersistentSO;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.OneTimeDataSetter
{
	[DefaultExecutionOrder(int.MinValue)]
	public abstract class BaseOneTimeSetterDelegate<T> : MonoBehaviour
	{
		[SerializeField]
		private bool setOnAwake;

		[SerializeField]
		private bool setOnStart;

		[SerializeField]
		private PersistentBoolVariable isSet;

		[SerializeField]
		private List<BoolVariableReference> setConditions;

		public UnityEvent<T> SetDataEvent;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void TrySet()
		{
		}

		protected abstract T GetData();
	}
}
