using ElephantSDK;
using UnityEngine;

[CreateAssetMenu(fileName = "ElephantRemoteConfigSource", menuName = "Crescive/Integrations/RemoteConfig/ElephantRemoteConfigSource")]
public class ElephantRemoteConfigSourceIntegration : CresciveBaseRemoteConfigSource
{
	private RemoteConfig RemoteConfig => null;

	public override string GetString(string key, string def = null)
	{
		return null;
	}

	public override int GetInt(string key, int def = 0)
	{
		return 0;
	}

	public override float GetFloat(string key, float def = 0f)
	{
		return 0f;
	}

	public override bool GetBool(string key, bool def = false)
	{
		return false;
	}
}
