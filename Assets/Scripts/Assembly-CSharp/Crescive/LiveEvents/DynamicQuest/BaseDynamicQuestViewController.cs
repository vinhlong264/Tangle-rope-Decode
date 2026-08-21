using Crescive.HelperTypes;
using Crescive.Theming;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.LiveEvents.DynamicQuest
{
	[DefaultExecutionOrder(1)]
	public abstract class BaseDynamicQuestViewController : MonoBehaviour
	{
		[SerializeField]
		protected DynamicQuestSystem dynamicQuestSystem;

		[SerializeField]
		protected BaseDynamicQuestUISettings uiSettings;

		[SerializeField]
		protected UIThemeSetter themeSetter;

		[SerializeField]
		private BoolSettableVariableReference isGoldenPassEnabled;

		[SerializeField]
		private BoolSettableVariableReference isGoldenPassActive;

		[SerializeField]
		private BoolSettableVariableReference canPurchaseGoldenPass;

		[SerializeField]
		protected bool didSetData;

		public UnityEvent OnSetup;

		protected DynamicQuestConfig Config => null;

		protected DynamicQuestData SaveData => null;

		protected DynamicQuestUIData UIData => null;

		public DynamicQuestSystem DynamicQuestSystem => null;

		public bool IsGoldenPassEnabled => false;

		public bool IsGoldenPassActive => false;

		public bool IsGoldenPassLive => false;

		public bool CanPurchaseGoldenPass => false;

		public bool IsGoldenPassPurchased => false;

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected void SyncBindings()
		{
		}

		protected virtual void SyncBindingsInternal()
		{
		}

		protected virtual void SetupInternal()
		{
		}

		protected virtual void ResetViewInternal()
		{
		}

		public void Setup(string dynamicQuestId)
		{
		}

		public void ResetView()
		{
		}
	}
}
