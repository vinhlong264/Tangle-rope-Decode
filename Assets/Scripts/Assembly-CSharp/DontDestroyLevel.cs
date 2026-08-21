using CresciveCore.Utils;
using UnityEngine;

[DefaultExecutionOrder(-999999999)]
public class DontDestroyLevel : Singleton<DontDestroyLevel>
{
	[SerializeField]
	private Transform obiParent;

	public Transform ObiParent => null;

	public void SetObiParentRotation(Vector3 rotation)
	{
	}
}
