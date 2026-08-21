using Crescive.Channels;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.TwistedTangle
{
	[CreateAssetMenu(fileName = "CutControllerChannel", menuName = "GameData/Channel/CutControllerChannel")]
	public class CutControllerChannel : ObjectChannel<CutController>
	{
		public UnityEvent OnEnableCutting => null;

		public UnityEvent OnDisableCutting => null;

		public UnityEvent OnAnyRopeCut => null;

		public void EnableCutting()
		{
		}

		public void DisableCutting()
		{
		}

		public void SetCutController(CutController controller)
		{
		}
	}
}
