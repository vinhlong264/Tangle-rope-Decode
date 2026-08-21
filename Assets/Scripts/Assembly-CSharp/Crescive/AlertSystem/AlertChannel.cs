using PersistentSO;
using UnityEngine;

namespace Crescive.AlertSystem
{
	[CreateAssetMenu(fileName = "AlertChannel", menuName = "Crescive/Alert System/Alert Channel")]
	public class AlertChannel : PersistentVariable<AlertChannelData>
	{
		public override AlertChannelData GetCopy(AlertChannelData value)
		{
			return null;
		}
	}
}
