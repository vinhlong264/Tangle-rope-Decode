using System;
using UnityEngine;

namespace Crescive.TwistedTangle.SpecialEditor
{
	[CreateAssetMenu(fileName = "ImageBGChannel", menuName = "Special Editor/Image BG Channel")]
	public class ImageBGChannel : ScriptableObject
	{
		public Action<float> OnScaleXChanged;

		public Action<float> OnScaleYChanged;

		public Action<float> OnOffsetXChanged;

		public Action<float> OnOffsetZChanged;

		public Action<float> OnRotationYChanged;

		public Action OnSwitchActivation;

		public Action OnAssignBG;

		public void SwitchActivation()
		{
		}

		public void AssignBG()
		{
		}

		public void SetScaleX(float newVal)
		{
		}

		public void SetScaleZ(float newVal)
		{
		}

		public void SetOffsetX(float newVal)
		{
		}

		public void SetOffsetZ(float newVal)
		{
		}

		public void SetRotationY(float newVal)
		{
		}
	}
}
