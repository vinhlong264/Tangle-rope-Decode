using UnityEngine;
using UnityEngine.Events;

public class ParticleSystemStopCallback : MonoBehaviour
{
	[SerializeField]
	[Header("Events")]
	private UnityEvent onParticleSystemStopped;

	private void OnParticleSystemStopped()
	{
	}
}
