using Crescive.Channels;
using RSG;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.RaceSystem
{
	[CreateAssetMenu(fileName = "Race System", menuName = "Crescive/Race System/Core/Race System")]
	public class RaceSystem : ObjectChannel<RaceController>
	{
		[field: SerializeField]
		public BoolVariable RaceEnabled { get; private set; }

		[field: SerializeField]
		public RaceEvents RaceEvents { get; private set; }

		[field: SerializeField]
		public RaceService RaceService { get; private set; }

		public IPromise<RaceStatus> GetRaceStatus()
		{
			return null;
		}
	}
}
