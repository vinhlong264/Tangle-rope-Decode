using System.Collections.Generic;
using UnityEngine;

namespace Crescive.DataService
{
	[DefaultExecutionOrder(-10000)]
	public class DataServicesSetup : MonoBehaviour
	{
		[SerializeField]
		private List<BaseDataReadService> dataServices;

		[SerializeField]
		private bool getOnAwake;

		[SerializeField]
		private bool getOnStart;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Get()
		{
		}
	}
}
