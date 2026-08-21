using UnityEngine;

namespace Crescive.Utils
{
	[CreateAssetMenu(fileName = "StorePageOpener", menuName = "Crescive/Store/StorePageOpener")]
	public class StorePageOpener : ScriptableObject
	{
		[SerializeField]
		private string iosUrl;

		[SerializeField]
		private string androidUrl;

		public void OpenStore()
		{
		}
	}
}
