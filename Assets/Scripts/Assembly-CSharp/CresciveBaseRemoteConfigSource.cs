using UnityEngine;

public abstract class CresciveBaseRemoteConfigSource : ScriptableObject
{
	public abstract string GetString(string key, string def = null);

	public abstract int GetInt(string key, int def = 0);

	public abstract float GetFloat(string key, float def = 0f);

	public abstract bool GetBool(string key, bool def = false);
}
