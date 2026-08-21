using UnityEngine;

public abstract class AgeBaseGatePanel : MonoBehaviour
{
	[SerializeField]
	private GameObject pivot;

	protected virtual void ShowPanel()
	{
	}

	protected virtual void HidePanel()
	{
	}
}
