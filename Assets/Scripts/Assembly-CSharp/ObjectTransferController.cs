using UnityEngine;

public class ObjectTransferController : MonoBehaviour
{
	[SerializeField]
	private ObjectTransferControllerChannel channel;

	[SerializeField]
	private RectTransform canvasParent;

	[SerializeField]
	private Transform objectParent;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void TransferObject(ObjectTransferArgs args)
	{
	}
}
