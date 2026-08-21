using UnityEngine;
using UnityEngine.Events;

public class PlatformSpecificCallback : MonoBehaviour
{
	public UnityEvent OnIOSOnAwake;

	public UnityEvent OnAndroidOnAwake;

	public UnityEvent OnIOSOnStart;

	public UnityEvent OnAndroidOnStart;

	private bool IsIOS => false;

	private bool IsAndroid => false;

	private void Awake()
	{
	}

	private void Start()
	{
	}
}
