using System.Collections.Generic;
using UnityEngine;

namespace Crescive.Text
{
	[CreateAssetMenu(fileName = "Text3DCharsData", menuName = "ScriptableObjects/Text3D/Text3DCharsData")]
	public class Text3DCharsData : ScriptableObject
	{
		[Header("Settings")]
		[SerializeField]
		private Text3DChar missingChar;

		[SerializeField]
		private List<Text3DChar> chars;

		public List<Text3DChar> GetChars(string text)
		{
			return null;
		}
	}
}
