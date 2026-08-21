using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

public class InfiniteUnityEventCallbackDelegate : MonoBehaviour
{
	[SerializeField]
	private UnityEvent OnInvoked;

	[SerializeField]
	private FloatReference interval;

	[SerializeField]
	private FloatReference intervalDivider;

	[SerializeField]
	private FloatReference intervalMultiplier;

	[SerializeField]
	private bool isFirstInvokeWithoutDelay;

	private bool invokeEnabled;

	private float timer;

	private void Update()
	{
	}

	private void TryInvoke()
	{
	}

	private void PerformInvoke()
	{
	}

	public void StartInvoking()
	{
	}

	public void StopInvoking()
	{
	}
}
