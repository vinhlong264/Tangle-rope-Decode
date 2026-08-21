using Crescive.HelperTypes;
using UnityEngine;

namespace Crescive.Theming
{
	public class UIThemeSetter : MonoBehaviour, IUIThemeUser
	{
		[SerializeField]
		private UITheme theme;

		[SerializeField]
		private AutoTriggerMethod autoTriggerMethod;

		public UITheme Theme
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void SetTheme()
		{
		}
	}
}
