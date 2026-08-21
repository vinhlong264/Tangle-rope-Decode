using System.Runtime.InteropServices;
using UnityEngine;

namespace DynamicQuestTime
{
	public class DynamicQuestTimeEvents
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		public struct OnHomeButtonClicked : IEvent
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		public struct OnShowHomeButtonUI : IEvent
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		public struct OnHideHomeButtonUI : IEvent
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		public struct OnInfoButtonClicked : IEvent
		{
		}

		public struct OnRewardClaimClicked : IEvent
		{
			public ItemData itemData;

			public OnRewardClaimClicked(ItemData itemData)
			{
				this.itemData = null;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		public struct OnOpenDynamicQuestTimeUI : IEvent
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		public struct OnCloseDynamicQuestTimeUI : IEvent
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		public struct OnCheckDynamicQuestTimeUI : IEvent
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		public struct OnUpdateDynamicQuestTimeUI : IEvent
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		public struct OnDynamicQuestTimeProgressAddStarted : IEvent
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		public struct OnDynamicQuestTimeProgressUpdated : IEvent
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		public struct OnDynamicQuestTimeClaimPopupOpen : IEvent
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		public struct OnDynamicQuestTimeClaimPopupClosed : IEvent
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		public struct OnDynamicQuestTimeTutorialStarted : IEvent
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		public struct OnDynamicQuestTimeTutorialEnded : IEvent
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		public struct OnDynamicQuestTimeCloseTutorial : IEvent
		{
		}

		public struct OnDynamicQuestTimeProgressBarRewardPosition : IEvent
		{
			public Vector3 position;

			public OnDynamicQuestTimeProgressBarRewardPosition(Vector3 position)
			{
				this.position = default(Vector3);
			}
		}

		public struct OnDynamicQuestTimeProgressBarTokenPosition : IEvent
		{
			public Vector3 position;

			public OnDynamicQuestTimeProgressBarTokenPosition(Vector3 position)
			{
				this.position = default(Vector3);
			}
		}
	}
}
