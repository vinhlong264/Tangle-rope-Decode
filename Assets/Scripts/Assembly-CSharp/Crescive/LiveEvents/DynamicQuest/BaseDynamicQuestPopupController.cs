using Crescive.HelperTypes;
using Crescive.Navigation;
using UnityEngine;

namespace Crescive.LiveEvents.DynamicQuest
{
	public abstract class BaseDynamicQuestPopupController : BaseDynamicQuestViewController
	{
		[SerializeField]
		protected Navigatable navigatable;

		[SerializeField]
		protected StringSettableVariableReference title;

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void SyncBindingsInternal()
		{
		}
	}
}
