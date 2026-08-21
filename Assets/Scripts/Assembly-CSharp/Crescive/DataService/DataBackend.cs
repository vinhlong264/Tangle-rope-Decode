using System.Collections.Generic;
using RSG;
using UnityEngine;

namespace Crescive.DataService
{
	public abstract class DataBackend : MonoBehaviour
	{
		[SerializeField]
		private List<ScriptableObject> dataBackendUsers;

		public abstract IPromise<object> Get(string key);

		public abstract IPromise<object> Set(string key, object data);

		public abstract IPromise<object> Post(string key, object data);

		protected virtual void Start()
		{
		}
	}
}
