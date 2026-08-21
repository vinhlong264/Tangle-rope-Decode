using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Crescive.AlertSystem
{
	public class AlertBadge : MonoBehaviour
	{
		[SerializeField]
		private AlertChannel alertChannel;

		[SerializeField]
		private GameObject badgeVisualParent;

		[SerializeField]
		private TMP_Text alertText;

		public UnityEvent OnAlertBadgeActive;

		public UnityEvent OnAlertBadgeInactive;

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		private void OnAlertChannelDataChangedCallback(AlertChannelData data)
		{
		}
	}
}
