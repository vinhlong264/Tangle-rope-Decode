using Crescive.DataService;
using RSG;
using UnityEngine;

namespace Crescive.RaceSystem
{
	public class RaceServiceLocalBackendBehaviour : DataBackend
	{
		[SerializeField]
		private RaceServiceLocalBackendDatabase backendDatabase;

		private RaceServiceLocalBackend Backend { get; set; }

		protected override void Start()
		{
		}

		public void IncreasePlayerRacerCompletion(int amount)
		{
		}

		public override IPromise<object> Get(string key)
		{
			return null;
		}

		public override IPromise<object> Set(string key, object data)
		{
			return null;
		}

		public override IPromise<object> Post(string key, object data)
		{
			return null;
		}
	}
}
