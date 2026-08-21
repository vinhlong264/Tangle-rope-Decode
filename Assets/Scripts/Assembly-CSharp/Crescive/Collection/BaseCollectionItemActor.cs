using UnityEngine;
using UnityEngine.Events;

namespace Crescive.Collection
{
	public abstract class BaseCollectionItemActor : MonoBehaviour
	{
		public UnityEvent OnItemChanged;
	}
}
