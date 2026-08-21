using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Collection
{
	public abstract class BaseRWOfferPopupController : MonoBehaviour
	{
		[Header("Events")]
		public UnityEvent<string> OnShowItemId;

		public UnityEvent<int> OnShowItemAmount;
	}
}
