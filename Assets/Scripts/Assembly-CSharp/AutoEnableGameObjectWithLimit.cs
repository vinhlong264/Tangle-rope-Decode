using UnityEngine;
using UnityEngine.Events;

public class AutoEnableGameObjectWithLimit : MonoBehaviour
{
	[Header("Settings")]
	[SerializeField]
	private int autoShowLimit;

	[SerializeField]
	[Header("Events")]
	private UnityEvent OnEnabled;

	[SerializeField]
	private UnityEvent OnDisabled;

	[SerializeField]
	private UnityEvent OnAutoShowLimitReached;

	private int initialShowCount;

	private string SaveKey => null;

	private int ShowCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	public void TryToEnable()
	{
	}

	public void Enable()
	{
	}

	public void Disable(bool takeBackCount)
	{
	}
}
