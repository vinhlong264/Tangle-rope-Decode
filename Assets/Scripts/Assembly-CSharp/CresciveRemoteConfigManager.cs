using UnityEngine;

[DefaultExecutionOrder(-2147483640)]
public class CresciveRemoteConfigManager : MonoBehaviour
{
	[Header("References")]
	[SerializeField]
	private CresciveRemoteConfigData data;

	[SerializeField]
	private CresciveBaseRemoteConfigSource source;

	private void Awake()
	{
	}
}
