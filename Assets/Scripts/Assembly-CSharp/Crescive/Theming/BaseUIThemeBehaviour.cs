using UnityEngine;

namespace Crescive.Theming
{
	public abstract class BaseUIThemeBehaviour : MonoBehaviour, IUIThemeUser
	{
		[SerializeField]
		private UITheme theme;

		[SerializeField]
		private bool applyOnEnable;

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

		protected virtual void OnEnable()
		{
		}

		private void ApplyTheme()
		{
		}

		protected abstract void ApplyThemeInternal();
	}
}
