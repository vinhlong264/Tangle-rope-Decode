using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Crescive.TwistedTangle
{
	public class ShopEventsSender : MonoBehaviour
	{
		[SerializeField]
		private CresciveEventSender eventSender;

		[SerializeField]
		private StringVariable sceneTypeId;

		private string SceneTypeId => null;

		public void OnShopOpened()
		{
		}
	}
}
