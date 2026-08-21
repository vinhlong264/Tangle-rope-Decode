using System.Collections.Generic;
using UnityEngine;

namespace Crescive.HomeMenu
{
	public class PagesController : MonoBehaviour
	{
		[SerializeField]
		private List<GameObject> pages;

		public List<GameObject> Pages => null;

		public GameObject ActivePage => null;

		public void ShowPage(int index)
		{
		}
	}
}
