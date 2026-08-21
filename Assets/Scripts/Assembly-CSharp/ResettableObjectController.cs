using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(-10000)]
public class ResettableObjectController : MonoBehaviour
{
	[SerializeField]
	[Header("References")]
	[RequireInterface(typeof(IResettableObject))]
	private List<Object> resettableScriptableObjects;

	private void Awake()
	{
	}

	private void ResetAll()
	{
	}
}
