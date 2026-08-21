using PersistentSO;
using UnityEngine;
using UnityEngine.Events;

public class GameObjectEnableLimit : MonoBehaviour
{
	[Header("References")]
	[SerializeField]
	private PersistentIntVariable showCount;

	[Header("Settings")]
	[SerializeField]
	private bool autoEnable;

	[SerializeField]
	[Header("Events")]
	private UnityEvent OnCanEnable;

	[SerializeField]
	private UnityEvent OnCanNotEnable;

	private void OnEnable()
	{
	}

	public void TryEnable()
	{
	}
}
