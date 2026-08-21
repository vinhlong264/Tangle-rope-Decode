using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "GameData/Random", fileName = "RandomNames")]
public class RandomNames : ScriptableObject
{
	public List<string> names;

	public List<Sprite> flags;
}
