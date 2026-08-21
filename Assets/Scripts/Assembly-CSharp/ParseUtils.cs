using ElephantSocial.Model;
using Profile;
using UnityEngine;

public static class ParseUtils
{
	public static bool TryParseVector2Int(string input, out Vector2Int result, params char[] separators)
	{
		result = default(Vector2Int);
		return false;
	}

	public static bool TryParseTwoInts(string input, out int first, out int second, params char[] separators)
	{
		first = default(int);
		second = default(int);
		return false;
	}

	public static ProfileData TryGetProfileData(BoardPlayer boardData)
	{
		return null;
	}

	public static ProfileData TryGetProfileData(Player boardData)
	{
		return null;
	}
}
