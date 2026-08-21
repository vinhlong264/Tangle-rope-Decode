using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Navigation
{
	public class NavigationChannelListener : MonoBehaviour
	{
		[SerializeField]
		private bool listenMultipleChannels;

		[SerializeField]
		private NavigationChannel navigationChannel;

		[SerializeField]
		private List<NavigationChannel> navigationChannels;

		public UnityEvent<Navigatable> OnShow;

		public UnityEvent<string> OnShowId;

		public UnityEvent<Navigatable> OnPop;

		public UnityEvent<string> OnPopId;

		public UnityEvent OnStackEmpty;

		public UnityEvent OnStackNotEmpty;

		public UnityEvent OnAllStacksEmpty;

		public UnityEvent OnAnyStackNotEmpty;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SubscribeToChannel(NavigationChannel channel)
		{
		}

		private void UnsubscribeFromChannel(NavigationChannel channel)
		{
		}

		private void OnStackEmptyCallback()
		{
		}

		private void OnStackNotEmptyCallback()
		{
		}
	}
}
