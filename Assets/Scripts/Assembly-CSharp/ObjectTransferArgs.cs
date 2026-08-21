using System;
using UnityEngine;

[Serializable]
public class ObjectTransferArgs
{
	public GameObject target;

	public Vector3 endPosition;

	public ObjectTransferer transferer;

	public bool isCanvasPosition;

	public Action transferredCallback;

	public ObjectTransferArgs(GameObject target, Vector3 endPosition, ObjectTransferer transferer, bool isCanvasPosition, Action transferredCallback)
	{
	}
}
