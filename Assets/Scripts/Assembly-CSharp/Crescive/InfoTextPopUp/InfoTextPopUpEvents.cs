using UnityEngine;
using UnityEngine.Events;

namespace Crescive.InfoTextPopUp
{
	[CreateAssetMenu(fileName = "Info Text Pop Up Events", menuName = "Crescive/PopUp/Info Text Pop Up/Info Text Pop Up Events")]
	public class InfoTextPopUpEvents : ScriptableObject
	{
		public UnityEvent<InfoTextPopUpArgs> OnPush;

		public void Push(InfoTextPopUpArgs args)
		{
		}
	}
}
