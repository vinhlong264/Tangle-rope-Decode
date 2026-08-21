using Crescive.Channels;
using UnityEngine;

namespace Crescive.Utils
{
	[CreateAssetMenu(menuName = "Crescive/Channels/Object Selectors Channel", fileName = "Object Selectors Channel")]
	public class ObjectSelectorsChannel : ObjectsChannel<ObjectSelector>
	{
		public void SetCanSelect(bool canSelect)
		{
		}
	}
}
