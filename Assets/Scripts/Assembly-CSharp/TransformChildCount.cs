using UnityEngine;
using UnityEngine.Events;

public class TransformChildCount : MonoBehaviour
{
	[SerializeField]
	[Header("Events")]
	private UnityEvent<int> OnChildCountChanged;

	private void OnTransformChildrenChanged()
	{
	}
}
