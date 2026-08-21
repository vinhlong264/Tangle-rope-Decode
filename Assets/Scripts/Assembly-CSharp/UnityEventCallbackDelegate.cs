using Crescive.HelperTypes;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventCallbackDelegate : BaseUnityEventCallbackDelegate
{
	[Header("Trigger Settings")]
	[SerializeField]
	private AutoTriggerMethod autoTriggerMethods;

	[Header("Settings")]
	[SerializeField]
	private bool invokeWhenDisabled;

	[SerializeField]
	private bool oneShot;

	[SerializeField]
	private bool hasDelay;

	[SerializeField]
	private float delay;

	[SerializeField]
	private bool autoKillDelayTween;

	[SerializeField]
	private bool hasInterval;

	[SerializeField]
	private float interval;

	[Header("Events")]
	public UnityEvent OnInvoked;

	private bool didCall;

	private float lastCallTime;

	private Sequence delaySequence;

	public override UnityEvent OnBaseInvoked => null;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	public void Invoke()
	{
	}

	public void CancelDelayedInvoke()
	{
	}

	private void InvokeWithDelay()
	{
	}
}
public abstract class UnityEventCallbackDelegate<T> : BaseUnityEventCallbackDelegate
{
	[SerializeField]
	private AutoTriggerMethod autoTriggerMethods;

	[SerializeField]
	protected T staticParameter;

	[SerializeField]
	private bool invokeWhenDisabled;

	[SerializeField]
	private bool oneShot;

	[Space]
	[SerializeField]
	private bool hasDelay;

	[SerializeField]
	private float delay;

	[SerializeField]
	private bool hasFrameDelay;

	[SerializeField]
	private int frameDelay;

	[SerializeField]
	private bool autoKillDelayTween;

	[SerializeField]
	[Space]
	private bool hasInterval;

	[SerializeField]
	private float interval;

	public UnityEvent<T> OnInvoked;

	public UnityEvent OnInvokedNoValue;

	private bool didCall;

	private float lastCallTime;

	private Sequence delaySequence;

	private bool HasAnyDelay => false;

	protected virtual T InvokeParameter => default(T);

	protected virtual bool HideStaticParameter => false;

	public override UnityEvent OnBaseInvoked => null;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	public void Invoke()
	{
	}

	public void Invoke(T arg1)
	{
	}

	public void CancelDelayedInvoke()
	{
	}

	protected virtual void InvokeInternal(T arg1)
	{
	}

	private void InvokeWithDelay(T arg1)
	{
	}
}
