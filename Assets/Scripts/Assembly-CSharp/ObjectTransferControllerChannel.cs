using Crescive.Channels;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Object Transfer Controller Channel", menuName = "Crescive/Object Transfer/Channels/Object Transfer Controller Channel")]
public class ObjectTransferControllerChannel : ObjectChannel<ObjectTransferController>
{
	[Header("Events")]
	public UnityEvent<ObjectTransferArgs> OnTransferRequested;

	public void Transfer(ObjectTransferArgs args)
	{
	}
}
