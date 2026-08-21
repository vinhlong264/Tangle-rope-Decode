using System.Collections.Generic;
using UnityAtoms;
using UnityEngine;

[CreateAssetMenu(fileName = "CresciveRemoteConfigData", menuName = "Crescive/RemoteConfig/CresciveRemoteConfigData")]
public class CresciveRemoteConfigData : ScriptableObject, ISerializationCallbackReceiver
{
	[Header("Settings")]
	[SerializeField]
	private List<AtomBaseVariable> variables;

	[SerializeField]
	private List<AtomBaseVariable> exceptedVariablesInEditor;

	public List<AtomBaseVariable> Variables => null;

	public T GetVariable<T>(string name) where T : AtomBaseVariable
	{
		return null;
	}

	private void RemoveDuplications()
	{
	}

	public bool HasVariable(string value)
	{
		return false;
	}

	public bool HasVariable(AtomBaseVariable value)
	{
		return false;
	}

	private bool HasDuplication(AtomBaseVariable value)
	{
		return false;
	}

	private bool HasDuplication(string value)
	{
		return false;
	}

	public void OnBeforeSerialize()
	{
	}

	public void OnAfterDeserialize()
	{
	}
}
