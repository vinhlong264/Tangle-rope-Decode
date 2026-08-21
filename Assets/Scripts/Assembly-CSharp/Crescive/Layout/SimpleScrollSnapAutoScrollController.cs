using DanielLochner.Assets.SimpleScrollSnap;
using UnityEngine;

namespace Crescive.Layout
{
	public class SimpleScrollSnapAutoScrollController : MonoBehaviour
	{
		[SerializeField]
		private SimpleScrollSnap scrollSnap;

		[SerializeField]
		[Space]
		private bool isAutoScrolling;

		[SerializeField]
		private float autoScrollDuration;

		[SerializeField]
		private float autoScrollStartDelay;

		private float autoScrollTimer;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void SetAutoScrolling(bool value)
		{
		}
	}
}
