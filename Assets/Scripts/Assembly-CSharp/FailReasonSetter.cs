using UnityAtoms.BaseAtoms;
using UnityEngine;

public class FailReasonSetter : MonoBehaviour
{
	[SerializeField]
	private StringVariable failReasonVariable;

	[SerializeField]
	private string reason;

	private void OnEnable()
	{
	}
}
