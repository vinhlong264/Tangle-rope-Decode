using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Text
{
	public class Text3DBehaviour : MonoBehaviour
	{
		[SerializeField]
		[Header("References")]
		private Transform charsParent;

		[SerializeField]
		private Text3DCharsData charsData;

		[SerializeField]
		[Header("Settings")]
		private bool updateInEditor;

		[SerializeField]
		[Multiline]
		private string text;

		[SerializeField]
		private TextAlignment alignment;

		[SerializeField]
		private float size;

		[SerializeField]
		private bool isMonospace;

		[SerializeField]
		private float monospaceCharWidth;

		[SerializeField]
		private float spacing;

		[SerializeField]
		private Material material;

		private List<Text3DChar> chars;

		[Header("Events")]
		public UnityEvent OnTextUpdated;

		public UnityEvent<List<Text3DChar>> OnTextUpdatedChars;

		private float CharScale => 0f;

		private float CharSpacing => 0f;

		public Material Material
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float Size
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Spacing
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public TextAlignment Alignment
		{
			get
			{
				return default(TextAlignment);
			}
			set
			{
			}
		}

		private void UpdateTextInInspector()
		{
		}

		private void UpdateText()
		{
		}

		private Text3DChar InstantiateChar(Text3DChar currCharPrefab)
		{
			return null;
		}

		public void SetText(string newText)
		{
		}

		public void SetTextInt(int number)
		{
		}

		public void SetTextFloat(float number)
		{
		}

		public void SetTextIntAbbreviated(int number)
		{
		}

		public void SetTextFloatAbbreviated(float number)
		{
		}
	}
}
